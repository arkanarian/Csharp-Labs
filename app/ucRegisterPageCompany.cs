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
    public partial class ucRegisterPageCompany : UserControl
    {
        public ucRegisterPageCompany()
        {
            InitializeComponent();
            foreach (var bank in MainForm.Instanse.appModel.FinSystem.Banks)
            {
                cmbBankID.Items.Add(bank.BankID);
            }
            cmbBankID.SelectedIndex = 2;
            cmbType.SelectedIndex = 0;
        }
        private static ucRegisterPageCompany _instance;
        public static ucRegisterPageCompany Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucRegisterPageCompany();
                return _instance;
            }
        }

        private void btnRegClient_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instanse.PnlContainer.Controls.Contains(ucRegisterPageClient.Instance))
            {
                ucRegisterPageClient.Instance.Dock = DockStyle.Fill;
                MainForm.Instanse.PnlContainer.Controls.Add(ucRegisterPageClient.Instance);
            }
            ucRegisterPageClient.Instance.BringToFront();
        }
        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txbLogin.Text;
                string password = txbPassword.Text;
                string companyName = txtName.Text;
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                string telephone = txtTelephone.Text;
                string companyType = cmbType.Text;
                if (!int.TryParse(txtUNP.Text, out var UNP) || txtUNP.Text.Length != 8) throw new AppException("Incorrect Company ID. Must contain 8 numbers. Try again");
                if (!int.TryParse(cmbBankID.Text, out var bankID) || cmbBankID.Text.Length != 8) throw new AppException("Incorrect Bank ID. Must contain 8 numbers. Try again");
                if (login == "" || password == "" || companyName == "" || email == "" || telephone == "" || address == "")
                {
                    throw new AppException("Fields mustn't be empty");
                }
                MainForm.Instanse.appModel.SignUpUser(login, password, email, telephone, companyName, UNP, address, bankID, companyType);
                //txbLogin.Text = String.Empty;
                //txbPassword.Text = String.Empty;
                //txtName.Text = String.Empty;
                //txtAddress.Text = String.Empty;
                //txtEmail.Text = String.Empty;
                //txtTelephone.Text = String.Empty;
                //cmbType.Text = String.Empty;
                //txtUNP.Text = String.Empty;
                //txtBankID.Text = String.Empty;
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
