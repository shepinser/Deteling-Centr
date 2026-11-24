using System.Data;
using System.Text.RegularExpressions;

namespace WinFormsApp1;

// Правила работы приложения. Кнопки форм вызывают эти методы.
public static class AppData
{
    public static readonly string[] Statuses = ["Ожидает назначения мастера", "В работе", "Выполнен", "Отменён"];

    public static bool IsPlatePrefix(string plate)
    {
        if (plate.Length > 9) return false;
        for (int i = 0; i < plate.Length; i++)
        {
            bool letterPosition = i == 0 || i == 4 || i == 5;
            if (letterPosition ? !"ABEKMHOPCTYX".Contains(plate[i]) : plate[i] < '0' || plate[i] > '9') return false;
        }
        return true;
    }

    public static Session? Login(string login, string password)
    {
        // Сначала ищем менеджера, затем клиента. Пароль сравниваем с учётом регистра.
        foreach (string table in new[] { "Managers", "Clients" })
        {
            DataTable users = Db.Read($"SELECT * FROM [{table}] WHERE [Login]=?", login.Trim());
            if (users.Rows.Count == 0) continue;
            DataRow row = users.Rows[0];
            if (!string.Equals(Convert.ToString(row["Password"]), password, StringComparison.Ordinal)) return null;
            return table == "Managers"
                ? new Session(Convert.ToInt32(row["ID_Manager"]), Convert.ToString(row["FullName"])!, "Admin")
                : new Session(Convert.ToInt32(row["ID_Client"]), $"{row["LastName"]} {row["FirstName"]}", "Client");
        }
        return null;
    }

    public static void CheckLogin(string login, string? currentTable = null, int currentId = 0)
    {
        if (!Regex.IsMatch(login, @"^[A-Za-z0-9_]{3,50}$"))
            throw new Exception("Логин: от 3 до 50 английских букв, цифр или знаков подчёркивания.");
        foreach (string table in new[] { "Managers", "Clients" })
        {
            string id = table == "Managers" ? "ID_Manager" : "ID_Client";
            DataTable found = Db.Read($"SELECT [{id}] FROM [{table}] WHERE [Login]=?", login);
            foreach (DataRow row in found.Rows)
                if (table != currentTable || Convert.ToInt32(row[id]) != currentId)
                    throw new Exception("Этот логин уже занят. Введите другой.");
        }
    }

    public static void CheckPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password) || password.Length > 100)
            throw new Exception("Введите пароль длиной от 1 до 100 символов.");
    }

    public static void Register(string lastName, string firstName, string middleName,
        string phone, string login, string password)
    {
        if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName))
            throw new Exception("Введите фамилию и имя.");
        CheckPhone(phone); CheckLogin(login); CheckPassword(password);
        // Role и CreatedAt заполняются самой базой: Client и текущая дата.
        Db.Execute("INSERT INTO Clients (LastName,FirstName,MiddleName,Phone,[Login],[Password]) VALUES (?,?,?,?,?,?)",
            lastName.Trim(), firstName.Trim(), middleName.Trim(), NormalizePhone(phone), login.Trim(), password);
    }

    public static void CheckPhone(string phone)
    {
        NormalizePhone(phone);
    }

    public static string NormalizePhone(string phone)
    {
        if (!Regex.IsMatch(phone, @"^[+0-9 ()-]+$"))
            throw new Exception("Введите телефон по форме: +7 (900) 123-45-67.");
        string digits = new(phone.Where(c => c >= '0' && c <= '9').ToArray());
        if (digits.Length == 11 && (digits[0] == '7' || digits[0] == '8')) digits = digits[1..];
        if (digits.Length != 10) throw new Exception("Введите телефон полностью: +7 (900) 123-45-67.");
        return $"+7 ({digits[..3]}) {digits[3..6]}-{digits[6..8]}-{digits[8..]}";
    }

    public static void AdminOnly(Session session)
    {
        if (!session.IsAdmin) throw new Exception("Это действие доступно только администратору.");
    }

    public static DataTable Cars(Session session, int? clientId = null)
    {
        int? owner = session.IsAdmin ? clientId : session.Id;
        string sql = "SELECT a.ID_Car AS [ID], a.ClientID, c.LastName & ' ' & c.FirstName AS [Владелец], " +
            "a.CarName AS [Автомобиль], a.PlateNumber AS [Госномер], a.ProductionYear AS [Год выпуска] " +
            "FROM Cars AS a INNER JOIN Clients AS c ON a.ClientID=c.ID_Client";
        return owner.HasValue ? Db.Read(sql + " WHERE a.ClientID=? ORDER BY a.ID_Car", owner.Value)
            : Db.Read(sql + " ORDER BY a.ID_Car");
    }

    public static void AddCar(Session session, int clientId, string name, string plate, int year)
    {
        if (!session.IsAdmin && clientId != session.Id) throw new Exception("Можно добавить только свой автомобиль.");
        plate = plate.Trim().ToUpperInvariant();
        if ((plate.Length != 8 && plate.Length != 9) || !IsPlatePrefix(plate))
            throw new Exception("Заполните номер по форме: A123BC63 или A123BC163. Регион — 2 или 3 цифры. Буквы: A B E K M H O P C T Y X.");
        if (string.IsNullOrWhiteSpace(name) || name.Trim().Length > 100 ||
            !Regex.IsMatch(name, @"^[А-Яа-яЁёA-Za-z0-9 .()-]+$"))
            throw new Exception("Название: русские или английские буквы, цифры, пробелы, точка, скобки и дефис.");
        if (year < 1886 || year > DateTime.Today.Year) throw new Exception("Год выпуска — от 1886 до текущего года.");
        if (Db.Read("SELECT ID_Car FROM Cars WHERE PlateNumber=?", plate).Rows.Count > 0)
            throw new Exception("Автомобиль с таким госномером уже записан.");
        Db.Execute("INSERT INTO Cars (ClientID,CarName,PlateNumber,ProductionYear) VALUES (?,?,?,?)",
            clientId, name.Trim(), plate, year);
    }

    public static void DeleteCar(Session session, int carId)
    {
        DataTable car = Db.Read("SELECT ClientID FROM Cars WHERE ID_Car=?", carId);
        if (car.Rows.Count == 0) throw new Exception("Автомобиль уже удалён.");
        if (!session.IsAdmin && Convert.ToInt32(car.Rows[0][0]) != session.Id)
            throw new Exception("Можно удалить только свой автомобиль.");
        if (Db.Read("SELECT ID_Order FROM Orders WHERE CarID=?", carId).Rows.Count > 0)
            throw new Exception("У машины есть заказы. Удаление запрещено, чтобы сохранить историю.");
        Db.Execute("DELETE FROM Cars WHERE ID_Car=?", carId);
    }

    public static DataTable Orders(Session session)
    {
        string numberColumn = session.IsAdmin ? "o.OrderNumber" : "o.ClientOrderNumber";
        string sql = "SELECT o.ID_Order AS [ID], " + numberColumn + " AS [Номер заказа], c.LastName & ' ' & c.FirstName AS [Клиент], " +
            "a.CarName AS [Автомобиль], a.PlateNumber AS [Госномер], o.OrderDate AS [Дата], " +
            "o.Status AS [Статус], t.TotalPrice AS [Стоимость], m.FullName AS [Мастер], " +
            "o.Rating AS [Оценка], o.ReviewText AS [Отзыв] " +
            "FROM ((((Orders AS o INNER JOIN Clients AS c ON o.ClientID=c.ID_Client) " +
            "INNER JOIN Cars AS a ON o.CarID=a.ID_Car) " +
            "LEFT JOIN Masters AS m ON o.MasterID=m.ID_Master) " +
            "LEFT JOIN OrderTotals AS t ON o.ID_Order=t.OrderID)";
        return session.IsAdmin ? Db.Read(sql + " ORDER BY o.OrderNumber")
            : Db.Read(sql + " WHERE o.ClientID=? ORDER BY o.OrderNumber", session.Id);
    }

    public static int CreateOrder(Session session, int clientId, int carId, int? masterId, int[] serviceIds)
    {
        if (!session.IsAdmin && clientId != session.Id) throw new Exception("Можно оформить только свой заказ.");
        if (serviceIds.Length == 0) throw new Exception("Выберите хотя бы одну услугу.");
        if (Db.Read("SELECT ID_Car FROM Cars WHERE ID_Car=? AND ClientID=?", carId, clientId).Rows.Count == 0)
            throw new Exception("Выберите автомобиль этого клиента.");
        int? assignedMaster = session.IsAdmin ? masterId : null;
        string initialStatus = assignedMaster.HasValue ? "В работе" : "Ожидает назначения мастера";
        int result = 0;
        Db.Transaction((connection, transaction) =>
        {
            using var numberCommand = Db.Command(connection, transaction, "SELECT Max(OrderNumber) FROM Orders");
            object? lastNumber = numberCommand.ExecuteScalar();
            int number = lastNumber is null or DBNull ? 1 : Convert.ToInt32(lastNumber) + 1;
            using var clientNumberCommand = Db.Command(connection, transaction,
                "SELECT Max(ClientOrderNumber) FROM Orders WHERE ClientID=?", clientId);
            object? lastClientNumber = clientNumberCommand.ExecuteScalar();
            int clientNumber = lastClientNumber is null or DBNull ? 1 : Convert.ToInt32(lastClientNumber) + 1;
            // У клиента менеджер и мастер пока не назначены. Администратор может назначить мастера позже.
            Db.Execute(connection, transaction,
                "INSERT INTO Orders (ClientID,CarID,ManagerID,MasterID,ServiceID,OrderDate,[Status],IsPaid,OrderNumber,PaidAt,ClientOrderNumber) VALUES (?,?,?,?,?,?,?,?,?,?,?)",
                clientId, carId, session.IsAdmin ? session.Id : null, assignedMaster,
                serviceIds[0], DateTime.Now, initialStatus, true, number, DateTime.Now, clientNumber);
            result = Db.NewId(connection, transaction);
            foreach (int serviceId in serviceIds.Distinct())
            {
                using var priceCommand = Db.Command(connection, transaction, "SELECT Price FROM Services WHERE ID_Service=?", serviceId);
                object? price = priceCommand.ExecuteScalar();
                if (price is null) throw new Exception("Выбранная услуга не найдена.");
                Db.Execute(connection, transaction,
                    "INSERT INTO OrderServices (OrderID,ServiceID,UnitPrice) VALUES (?,?,?)", result, serviceId, Convert.ToDecimal(price));
            }
        });
        return result;
    }

    public static DataTable OrderDetails(Session session, int orderId)
    {
        CheckOrderOwner(session, orderId);
        return Db.Read("SELECT s.ServiceName AS [Услуга], d.UnitPrice AS [Стоимость] FROM OrderServices AS d " +
            "INNER JOIN Services AS s ON d.ServiceID=s.ID_Service WHERE d.OrderID=?", orderId);
    }

    public static DataRow CheckOrderOwner(Session session, int orderId)
    {
        DataTable table = Db.Read("SELECT * FROM Orders WHERE ID_Order=?", orderId);
        if (table.Rows.Count == 0) throw new Exception("Заказ не найден.");
        if (!session.IsAdmin && Convert.ToInt32(table.Rows[0]["ClientID"]) != session.Id)
            throw new Exception("Этот заказ принадлежит другому клиенту.");
        return table.Rows[0];
    }

    public static void SetStatus(Session session, int orderId, string status, int? masterId)
    {
        AdminOnly(session); CheckOrderOwner(session, orderId);
        if (!Statuses.Contains(status)) throw new Exception("Выберите статус из списка.");
        if (status == "Выполнен" && !masterId.HasValue) throw new Exception("Для выполненного заказа выберите мастера.");
        if (status == "В работе" || status == "Ожидает назначения мастера")
            status = masterId.HasValue ? "В работе" : "Ожидает назначения мастера";
        Db.Execute("UPDATE Orders SET [Status]=?, MasterID=?, ManagerID=? WHERE ID_Order=?", status, masterId, session.Id, orderId);
    }

    public static void DeleteOrder(Session session, int orderId)
    {
        AdminOnly(session);
        Db.Transaction((connection, transaction) =>
        {
            Db.Execute(connection, transaction, "DELETE FROM OrderServices WHERE OrderID=?", orderId);
            Db.Execute(connection, transaction, "DELETE FROM Orders WHERE ID_Order=?", orderId);
        });
    }

    public static void DeleteRecord(Session session, string table, int id)
    {
        AdminOnly(session);
        // Имена таблиц берём только из этого списка, а номер передаём параметром.
        string key = table switch
        {
            "Clients" => "ID_Client", "Managers" => "ID_Manager",
            "Masters" => "ID_Master", "Services" => "ID_Service",
            _ => throw new Exception("Неизвестная таблица.")
        };
        if (table == "Managers" && id == session.Id)
            throw new Exception("Нельзя удалить аккаунт, под которым вы сейчас работаете.");
        string foreignKey = table switch
        {
            "Clients" => "ClientID", "Managers" => "ManagerID",
            "Masters" => "MasterID", _ => "ServiceID"
        };
        if (Db.Read($"SELECT ID_Order FROM Orders WHERE [{foreignKey}]=?", id).Rows.Count > 0 ||
            (table == "Services" && Db.Read("SELECT OrderID FROM OrderServices WHERE ServiceID=?", id).Rows.Count > 0))
            throw new Exception("Эта запись используется в заказах. Удалить её нельзя, чтобы сохранить данные заказов.");
        if (table == "Clients" && Db.Read("SELECT ID_Car FROM Cars WHERE ClientID=?", id).Rows.Count > 0)
            throw new Exception("У клиента есть автомобили. Сначала удалите его автомобили.");
        Db.Execute($"DELETE FROM [{table}] WHERE [{key}]=?", id);
    }

    public static void Pay(Session session, int orderId)
    {
        DataRow order = CheckOrderOwner(session, orderId);
        if (Convert.ToString(order["Status"]) == "Отменён") throw new Exception("Отменённый заказ нельзя оплатить.");
        if (Convert.ToBoolean(order["IsPaid"])) throw new Exception("Заказ уже отмечен как оплаченный.");
        Db.Execute("UPDATE Orders SET IsPaid=True, PaidAt=? WHERE ID_Order=?", DateTime.Now, orderId);
    }

    public static void Review(Session session, int orderId, int rating, string text)
    {
        if (session.IsAdmin) throw new Exception("Отзыв оставляет клиент.");
        DataRow order = CheckOrderOwner(session, orderId);
        if (Convert.ToString(order["Status"]) != "Выполнен") throw new Exception("Отзыв можно оставить после выполнения заказа.");
        if (rating < 1 || rating > 5) throw new Exception("Оценка — от 1 до 5.");
        Db.Execute("UPDATE Orders SET Rating=?, ReviewText=? WHERE ID_Order=?", rating, text.Trim(), orderId);
    }
}
