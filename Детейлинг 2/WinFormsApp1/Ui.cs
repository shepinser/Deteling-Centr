using System.Data;

namespace WinFormsApp1;

public static class Ui
{
    public static void Try(Action action)
    {
        try { action(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Проверьте данные", MessageBoxButtons.OK, MessageBoxIcon.Information); }
    }
    public static void Bind(ComboBox combo, DataTable table, string value, string display)
    { combo.DisplayMember=display; combo.ValueMember=value; combo.DataSource=table; }
    public static int Selected(ComboBox combo)
    {
        if (combo.SelectedValue is null or DBNull or DataRowView) throw new Exception("Выберите значение из списка.");
        return Convert.ToInt32(combo.SelectedValue);
    }
    public static void Phone(MaskedTextBox phone)
    {
        bool prefixEntered=false;
        void PositionCaret()
        {
            // Выделение текста оставляем для копирования, вставки и удаления.
            if (phone.SelectionLength>0 || phone.MaskedTextProvider is not { } mask) return;
            int first=mask.FindEditPositionFrom(0,true);
            int empty=mask.FindUnassignedEditPositionFrom(0,true);
            int last=mask.FindEditPositionFrom(mask.Length-1,false);
            int limit=empty>=0?empty:last+1;
            int position=Math.Clamp(phone.SelectionStart,first,limit);
            if (position<=last && !mask.IsEditPosition(position))
            {
                int next=mask.FindEditPositionFrom(position,true);
                position=next>=0?Math.Min(next,limit):limit;
            }
            phone.SelectionStart=position;
        }
        phone.Enter += (_,_) => { if(phone.IsHandleCreated) phone.BeginInvoke((Action)PositionCaret); };
        phone.MouseUp += (_,_) => PositionCaret();
        phone.KeyUp += (_,_) => PositionCaret();
        phone.KeyPress += (_,e) =>
        {
            // Начальную 8 или 7 заменяет уже напечатанный в маске код +7.
            if (!prefixEntered && phone.MaskedTextProvider!.AssignedEditPositionCount==0 && (e.KeyChar=='8' || e.KeyChar=='7'))
            { e.Handled=true; prefixEntered=true; phone.SelectionStart=4; }
        };
        phone.KeyDown += (_,e) =>
        {
            if ((e.Control && e.KeyCode==Keys.V) || (e.Shift && e.KeyCode==Keys.Insert))
            {
                e.SuppressKeyPress=true;
                Try(() => { phone.Text=AppData.NormalizePhone(Clipboard.GetText()); phone.SelectionStart=phone.Text.Length; });
            }
        };
    }
}
