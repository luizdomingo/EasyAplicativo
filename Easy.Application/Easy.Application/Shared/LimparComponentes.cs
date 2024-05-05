using Guna.UI2.WinForms;

namespace Easy.ApplicationDesk.Shared
{
    public static class LimparComponentes
    {
        public static void LimparFlowLayoutPanel(this FlowLayoutPanel flow)
        {
            foreach (object? ctr in flow.Controls)
            {
                if (ctr.GetType() == typeof(Guna2TextBox))
                {
                    Guna2TextBox textbox = (Guna2TextBox)ctr;
                    textbox.Clear();
                }
            }
        }
    }
}
