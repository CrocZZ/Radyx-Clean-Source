using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Radyx;
namespace Radyx
{
    static class Program
    {
        public static bool IsSingleInstance()
        {
            try
            {
                Mutex.OpenExisting("Radyx");
            }
            catch
            {
                Program._m = new Mutex(true, "Radyx");
                return true;
            }
            return false;
        }
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Program.IsSingleInstance())
            {
                MessageBox.Show("Radyx Builder already running.\n\nPlease close other processes!", "Radyx Already Running", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }
            else
            {
                Application.Run(new Form1());

            }

        }
        public static Mutex _m;
    }
}
