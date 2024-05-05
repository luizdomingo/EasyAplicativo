using Easy.ApplicationDesk.Properties;

namespace Easy.ApplicationDesk.Forms.Alerta
{
    public partial class FrmAlerta : Form
    {
        private Form parentForm;

        public FrmAlerta()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private enmAction action;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (Opacity == 1.0)
                    {
                        action = enmAction.wait;
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    Opacity -= 0.1;
                    if (Opacity == 0.0)
                    {
                        Close();
                    }
                    break;
            }
        }

        public void ShowAlert(Form parent, string msg, enmType type)
        {
            parentForm = parent;
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;

            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FrmAlerta frm = (FrmAlerta)System.Windows.Forms.Application.OpenForms[fname];

                if (frm == null)
                {
                    Name = fname;
                    Left = parentForm.Left + parentForm.Width - Width; // Posicionando à direita do formulário pai
                    Top = parentForm.Top + parentForm.Height * i + 10 * i;
                    break;
                }
            }

            switch (type)
            {
                case enmType.Success:
                    pictureBox1.Image = Resources.success;
                    BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    pictureBox1.Image = Resources.error;
                    BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    pictureBox1.Image = Resources.info;
                    BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    pictureBox1.Image = Resources.warning;
                    BackColor = Color.DarkOrange;
                    break;
            }

            lblMsg.Text = msg;

            Show();
            action = enmAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}
