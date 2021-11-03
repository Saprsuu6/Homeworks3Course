using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            AddQuestion addQuestion = new AddQuestion();
            RemoveQuestion removeQuestion = new RemoveQuestion();
            ChangeQuestion changeQuestion = new ChangeQuestion();
            Presenter presenter = new Presenter(mainForm, addQuestion, removeQuestion, changeQuestion);

            mainForm.Presenter = presenter;
            addQuestion.Presenter = presenter;
            removeQuestion.Presenter = presenter;
            changeQuestion.Presenter = presenter;

            Application.Run(mainForm);
        }
    }
}
