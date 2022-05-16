using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationForm
{
    public partial class ucLoginPage : UserControl
    {
        public ucLoginPage()
        {
            InitializeComponent();
        }
        private static ucLoginPage _instance;
        public static ucLoginPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLoginPage();
                return _instance;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txbLogin.Text;
                string password = txbPassword.Text;
                if (login == "" || password == "") {
                    throw new AppException("Fields mustn't be empty");
                }
                MainForm.Instanse.appModel.SignInUser(login, password);
                if (!MainForm.Instanse.PnlContainer.Controls.ContainsKey("ucHomePage"))
                {
                    ucHomePage.Instance.Dock = DockStyle.Fill;
                    MainForm.Instanse.PnlContainer.Controls.Add(ucHomePage.Instance);
                }
                ucHomePage.Instance.BringToFront();
                MainForm.Instanse.UserSignedIn();
            }
            catch (AppException ex)
            {
                ex.ShowErrorMessage();
            }
        }
    }
}
