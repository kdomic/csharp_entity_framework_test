using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PutniNalozi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static void LoadForm(Form form, Form pattent)
        {
            foreach (Form f in pattent.MdiChildren)
            {
                f.Close();
            }
            if (form == null) return;
            form.MdiParent = pattent;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

    }
}
