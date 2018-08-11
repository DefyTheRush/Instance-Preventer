using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace dsfsd
{
   static class Program
   {
       [STATThread]
       static void Main()
       {
           const string appName = "dsfsd";
           bool createdNew;

           Mutex mutex = new Mutex(true, appName, out createdNew);

           if (!createdNew)
           {
             MessageBox.Show("You cannot have more than one instance of this program running", "Already running");
             return;
           }

           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new 34());
       }
    }
}
