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
    public partial class ucErrorPage : UserControl
    {
        public ucErrorPage()
        {
            InitializeComponent();
        }
        private static ucErrorPage _instance;
        public static ucErrorPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucErrorPage();
                return _instance;
            }
        }
        public void SetErrorText(string errorText)
        {
            lbErrorMessage.Text = errorText;
            lbErrorMessage.Visible = true;
            lbErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            //lbErrorMessage.Left = lbErrorMessage.Left + (panel2.Width+ 10 - lbErrorMessage.Width) / 2;
        }

        private void btnCloseErrorPage_Click(object sender, EventArgs e)
        {
            ucErrorPage.Instance.Visible = false;
        }
    }
}
