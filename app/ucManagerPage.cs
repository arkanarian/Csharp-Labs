using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelsLibrary.Entities;
using ModelsLibrary.Interfaces;

namespace ApplicationForm
{
    public partial class ucManagerPage : UserControl
    {
        public ucManagerPage()
        {
            InitializeComponent();
        }
        private static ucManagerPage _instance;
        public static ucManagerPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucManagerPage();
                return _instance;
            }
        }
        public void LoadData()
        {

        }
        public void ClearData()
        {

        }
    }
}
