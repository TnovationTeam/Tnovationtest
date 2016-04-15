using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNovationProject
{//////////////////////////////// TEAM MEMBERS PLEASE DONT DELETE THIS CLASS FILE    ////////////////////////
    static class Program
    {

        // the main entry point of the application
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mdiBackend());
        }
    }
}
