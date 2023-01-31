using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenaid_IDE
{

    static class Program
    {

        
        public static string filedir;
        public static string grfdir;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
           
            if (!File.Exists(@"C:\greenaide\isprogins.dll"))
            {
                Application.Run(new creatininitialfiles());


            }


          

            if (Directory.Exists(@"C:\greenaide") && File.Exists(@"C:\greenaide\isprogins.dll"))
            {
               

                try
                {
                  
                    filedir = File.ReadAllText(@"C:\greenaide\currentdir.dll");
                    grfdir = File.ReadAllText(@"C:\greenaide\currentdirgrf.dll");
                    if (File.Exists(grfdir))
                    {
                        File.WriteAllText(grfdir, filedir);
                    }




                    File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
                    Application.Run(new mainmenu());
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong when opening Greenaid IDE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                    Application.Exit();
                   
                }
                

                
            }
        }
    }
}
