using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public static class Program
    {
        public static OrderForm orderForm;
        public static SelectForm selectForm;
        public static Views.StartForm startForm;
        public static ProductInfoForm proudctInfotForm;
        public static SplashForm splashtForm;
        public static AboutForm aboutForm;



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            orderForm = new OrderForm();
            selectForm = new SelectForm();
            startForm = new Views.StartForm();
            splashtForm = new SplashForm();
            aboutForm = new AboutForm();
            Application.Run(orderForm);
        }
    }
}
