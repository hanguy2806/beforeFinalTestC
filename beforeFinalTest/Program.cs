using beforeFinalTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beforeFinalTest
{
    static class Program
    {
        
        public static CharacterGenerationForm characterForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             characterForm= new CharacterGenerationForm();
            Application.Run(characterForm);
        }
    }
}
