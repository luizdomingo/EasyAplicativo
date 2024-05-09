using Guna.UI2.WinForms;

namespace Easy.ApplicationDesk.Shared
{
    public static class ValidarComponentes
    {
        public static void FlowLayoutPanel(this FlowLayoutPanel flow)
        {
            foreach (object? ctr in flow.Controls)
            {
                if (ctr.GetType() == typeof(Guna2TextBox))
                {
                    Guna2TextBox textbox = (Guna2TextBox)ctr;
                    if (textbox.Text == string.Empty)
                    {
                        textbox.PlaceholderForeColor = Color.Red;
                        textbox.PlaceholderText = "Campo obrigatório";
                    }
                }
            }
        }
    }
}
