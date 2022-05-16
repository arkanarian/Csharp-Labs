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
    public partial class ucRegisterPageClient : UserControl
    {
        public ucRegisterPageClient()
        {
            InitializeComponent();
        }
        private static ucRegisterPageClient _instance;
        public static ucRegisterPageClient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucRegisterPageClient();
                return _instance;
            }
        }

        private void btnRegEnterprise_Click(object sender, EventArgs e)
        {
            //if (!MainForm.Instanse.PnlContainer.Controls.Contains(ucRegisterPageCompany.Instance))
            //{
                //ucRegisterPageCompany register_page = new ucRegisterPageCompany();
                //register_page.Dock = DockStyle.Fill;
                //MainForm.Instanse.PnlContainer.Controls.Add(register_page);
            //}
            //MainForm.Instanse.PnlContainer.Controls["ucRegisterPageEnterprise"].BringToFront();
            if (!MainForm.Instanse.PnlContainer.Controls.Contains(ucRegisterPageCompany.Instance))
            {
                ucRegisterPageCompany.Instance.Dock = DockStyle.Fill;
                MainForm.Instanse.PnlContainer.Controls.Add(ucRegisterPageCompany.Instance);
            }
            ucRegisterPageCompany.Instance.BringToFront();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txbLogin.Text;
                string password = txbPassword.Text;
                string name = txbFName.Text + ' ' + txbLName.Text;
                if (!int.TryParse(txbPassportID.Text, out var passportID) || txbPassportID.Text.Length != 7) throw new AppException("Incorrect Passport ID. Must contain 7 numbers. Try again");
                string passportNum = txbPassportNum.Text;
                string email = txbEmail.Text;
                string telephone = txbTelephone.Text;
                if (login == "" || password == "" || txbFName.Text == "" || txbLName.Text == "" || passportNum == "" || email == "" || telephone == "")
                {
                    throw new AppException("Fields mustn't be empty");
                }
                MainForm.Instanse.appModel.SignUpUser(name, login, password, telephone, email, passportNum, passportID);
                //txbLogin.Text = String.Empty;
                //txbPassword.Text = String.Empty;
                //txbFName.Text = String.Empty;
                //txbLName.Text = String.Empty;
                //txbPassportID.Text = String.Empty;
                //txbPassportNum.Text = String.Empty;
                //txbEmail.Text = String.Empty;
                //txbTelephone.Text = String.Empty;
                MainForm.Instanse.UserSignedIn();
            }
            catch (AppException ex)
            {
                ex.ShowErrorMessage();
            }
            catch (FormatException ex)
            {
                AppException appex = new AppException(ex.Message);
                appex.ShowErrorMessage();
            }
            catch (Exception ex)
            {
                AppException appex = new AppException(ex.Message);
                appex.ShowErrorMessage();
            }
        }
    }
}
