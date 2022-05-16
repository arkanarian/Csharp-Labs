using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelsLibrary.Entities;

namespace ApplicationForm
{
    [Serializable]
    public class AppException :Exception
    {
        private string ErrMessage = "";
        public AppException()
        {
        }

        public AppException(string message)
            : base(message)
        {
            this.ErrMessage = message;
        }
        public AppException(string message, Exception inner)
            : base(message, inner)
        {
            this.ErrMessage = message;
        }

        public void ShowErrorMessage()
        {
            if (!MainForm.Instanse.PnlContainer.Controls.Contains(ucErrorPage.Instance))
            {
                ucErrorPage.Instance.Left = MainForm.Instanse.Width / 2 - ucErrorPage.Instance.Width / 2;
                ucErrorPage.Instance.Top = MainForm.Instanse.Height / 2 - ucErrorPage.Instance.Height / 2 - 50;
                MainForm.Instanse.PnlContainer.Controls.Add(ucErrorPage.Instance);
            }
            ucErrorPage.Instance.BringToFront();
            ucErrorPage.Instance.Visible = true;
            ucErrorPage.Instance.SetErrorText(ErrMessage);
        }
    }
}
