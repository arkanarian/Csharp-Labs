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
    public partial class ucHomePage : UserControl
    {
        public ucHomePage()
        {
            InitializeComponent();
        }
        private static ucHomePage _instance;
        public static ucHomePage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHomePage();
                return _instance;
            }
        }
    }
}
