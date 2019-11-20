using System.Windows.Forms;

namespace B4llista
{
    public partial class UpdateAuth : Form
    {
        public UpdateAuth()
        {
            InitializeComponent();
            this.lbl_authCode.Text = ".link " + Globals.AuthCode;
        }
    }
}
