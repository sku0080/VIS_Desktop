using System;
using System.Windows.Forms;
using VIS_Desktop.Classes.Database;

namespace VIS_Desktop
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database db = new Database();
            db.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            db.Close();
        }
    }
}
