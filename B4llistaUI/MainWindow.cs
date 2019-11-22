using System;
using System.Threading;
using System.Windows.Forms;
using PlutoLib;

namespace B4llistaUI
{
    public partial class MainWindow : Form
    {
        public int state = 0;

        public MainWindow()
        {
            InitializeComponent();
            if (Globals.Cookie == null)
            {
                this.lbl_config1.Visible = true;
                this.btn_configuration.Padding = new Padding(20, 0, 0, 0);
                this.pic_err1.Visible = true;
                this.pic_err2.Visible = true;
                this.pic_err3.Visible = true;
            }
            ShowDashboard(this, null);
        }

        private void ConfirmExit(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Ballista", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) Environment.Exit(1);
        }

        private void ShowDashboard(object sender, EventArgs e)
        {
            if (state == 1) return;
            state = 1;
            this.pnl_dashboard.Visible = true;
            this.pnl_configuration.Visible = false;
            this.pnl_billing.Visible = false;
        }

        private void ShowConfiguration(object sender, EventArgs e)
        {
            if (state == 2) return;
            state = 2;
            this.pnl_dashboard.Visible = true;
            this.pnl_configuration.Visible = true;
            this.pnl_billing.Visible = false;
        }

        private void ShowBilling(object sender, EventArgs e)
        {
            if (state == 3) return;
            state = 3;
            this.pnl_dashboard.Visible = true;
            this.pnl_configuration.Visible = true;
            this.pnl_billing.Visible = true;
        }

        private void StartBot(object sender, EventArgs e)
        {
            if (Globals.Cookie == null)
            {
                ShowConfiguration(this, null);
                return;
            }

            // require plutolib -> start bot
        }
    }
}
