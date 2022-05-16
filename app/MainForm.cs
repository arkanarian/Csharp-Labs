using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using ModelsLibrary.Entities;
using ModelsLibrary.Interfaces;

namespace ApplicationForm
{
    public partial class MainForm : Form
    {
        public AppModel appModel { get; private set; }
        static MainForm _form;
        public MainForm()
        {
            InitializeComponent();
        }
        public static MainForm Instanse
        {
            get
            {
                if(_form == null)
                {
                    _form = new MainForm();
                }
                return _form;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            appModel = new AppModel();
            //appModel.LoadDataFromFile();
            _form = this;
            ucHomePage.Instance.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(ucHomePage.Instance);
            ucHomePage.Instance.BringToFront();
            ChangeHeaderToSignedOut();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            appModel.StoreDataToFile();
            appModel.CloseLog();
        }

        public void ChangeHeaderToSignedIn()
        {
            btn_register.Visible = false;
            btn_signin.Visible = false;
            lbLogin.Text = appModel.CurrentUser.Login + ' ' + '(' + appModel.CurrentUser.GetType().Name + ')';
            lbLogin.Left = _form.Size.Width - lbLogin.Width - 170;
            btnLogOut.Left = _form.Size.Width - btnLogOut.Width - 30;
            btnLogOut.Visible = true;
            lbLogin.Visible = true;
        }
        public void ChangeHeaderToSignedOut()
        {
            lbLogin.Visible = false;
            btnLogOut.Visible = false;
            btn_register.Visible = true;
            btn_signin.Visible = true;
        }
        public void UserSignedIn()
        {
            ChangeHeaderToSignedIn();
            ShowUserPage();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("ucLoginPage"))
            {
                ucLoginPage.Instance.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ucLoginPage.Instance);
            }
            ucLoginPage.Instance.BringToFront();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("ucRegisterPageClient"))
            {
                ucRegisterPageClient.Instance.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ucRegisterPageClient.Instance);
            }
            ucRegisterPageClient.Instance.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowHomePage();
        }
        private void ShowHomePage()
        {
            if (!PnlContainer.Controls.ContainsKey("ucHomePage"))
            {
                ucHomePage.Instance.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ucHomePage.Instance);
            }
            ucHomePage.Instance.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ShowHomePage();
            ChangeHeaderToSignedOut();
            // ОПАСНО! Если зарегались компанией, вышли, очищает компанию, потом зарегались юзером, вышли, то очищает и компанию и юзера
            if (PnlContainer.Controls.ContainsKey("ucCompanyPage"))
            {
                ucCompanyPage.Instance.ClearData();
            }
            if (PnlContainer.Controls.ContainsKey("ucClientPage"))
            {
                ucClientPage.Instance.ClearData();
            }
            appModel.LogOutUser();
        }
        private void ShowUserPage()
        {
            // client
            if (appModel.CurrentUser.UserType == UserType.Client)
            {
                if (!PnlContainer.Controls.ContainsKey("ucClientPage"))
                {
                    ucClientPage.Instance.Dock = DockStyle.Fill;
                    PnlContainer.Controls.Add(ucClientPage.Instance);
                }
                ucClientPage.Instance.BringToFront();
                if (!ucClientPage.Instance.PnlContainer.Controls.ContainsKey("ucClientAccounts"))
                {
                    ucClientAccounts.Instance.Dock = DockStyle.Fill;
                    ucClientPage.Instance.PnlContainer.Controls.Add(ucClientAccounts.Instance);
                }
                ucClientAccounts.Instance.BringToFront();
                ucClientPage.Instance.LoadData();
            }
            // company
            else if (appModel.CurrentUser.UserType == UserType.Company)
            {
                if (!PnlContainer.Controls.ContainsKey("ucCompanyPage"))
                {
                    ucCompanyPage.Instance.Dock = DockStyle.Fill;
                    PnlContainer.Controls.Add(ucCompanyPage.Instance);
                }
                ucCompanyPage.Instance.BringToFront();
                if (!ucCompanyPage.Instance.PnlContainer.Controls.ContainsKey("ucCompanyAccounts"))
                {
                    ucCompanyAccounts.Instance.Dock = DockStyle.Fill;
                    ucCompanyPage.Instance.PnlContainer.Controls.Add(ucCompanyAccounts.Instance);
                }
                ucCompanyAccounts.Instance.BringToFront();
                ucCompanyAccounts.Instance.LoadData();
            }
            // operator
            else if (appModel.CurrentUser.UserType == UserType.Operator)
            {
                if (!PnlContainer.Controls.ContainsKey("ucOperatorPage"))
                {
                    ucOperatorPage.Instance.Dock = DockStyle.Fill;
                    PnlContainer.Controls.Add(ucOperatorPage.Instance);
                }
                ucOperatorPage.Instance.BringToFront();
                ucOperatorPage.Instance.LoadData();
            }
            // manager
            else if (appModel.CurrentUser.UserType == UserType.Manager)
            {
                if (!PnlContainer.Controls.ContainsKey("ucManagerPage"))
                {
                    ucManagerPage.Instance.Dock = DockStyle.Fill;
                    PnlContainer.Controls.Add(ucManagerPage.Instance);
                }
                ucManagerPage.Instance.BringToFront();
                ucManagerPage.Instance.LoadData();
            }
            // administrator
            else if (appModel.CurrentUser.UserType == UserType.Administrator)
            {
                if (!PnlContainer.Controls.ContainsKey("ucAdministratorPage"))
                {
                    ucAdministratorPage.Instance.Dock = DockStyle.Fill;
                    PnlContainer.Controls.Add(ucAdministratorPage.Instance);
                }
                ucAdministratorPage.Instance.BringToFront();
                ucAdministratorPage.Instance.LoadData();
            }
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            ShowUserPage();
        }
    }
}
