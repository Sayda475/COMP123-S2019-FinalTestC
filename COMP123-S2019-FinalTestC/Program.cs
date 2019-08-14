using COMP123_S2019_FinalTestC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Sayda Rahman
 * Student ID: 301042327
 * Description: This the  about form
 * 
 */
namespace COMP123_S2019_FinalTestC
{
    static class Program
    {
        public static SplashScreen splashScreen;
        public static CharacterGenerationForm characterForm;
        public static AboutForm aboutForm;

        internal static AboutForm AboutForm { get => aboutForm; set => aboutForm = value; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGenerationForm();
            splashScreen = new SplashScreen();
            aboutForm = new AboutForm();

            Application.Run(splashScreen);
        }
    }
}
