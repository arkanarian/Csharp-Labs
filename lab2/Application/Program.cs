using System;
using System.Windows.Forms;
using MVC;

namespace Laba2
{
    static class Program
    {
        public static Controller Controller = null;
        public static Model AppModel = null;
        public static DomainModel.FileInteractions DomainModel = null;
        public static MVC.View View = null;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            InitializeMVC();
            System.Windows.Forms.Application.Run(View.GetMainForm());
        }

        private static void InitializeMVC()
        {
            // Creating Model, View, Controller
            AppModel = new Model();
            DomainModel = new DomainModel.FileInteractions();
            View = new MVC.View();
            Controller = new Controller(AppModel, DomainModel, View);

            // Initializing Model, View, Controller
            Controller.Initialize();
            View.Initialize();
            DomainModel.Initialize(View.Graphics);
            
            // Additional initialization steps
            Controller.LoadPlugin();
            View.CreateMenu();
        }
    }
}