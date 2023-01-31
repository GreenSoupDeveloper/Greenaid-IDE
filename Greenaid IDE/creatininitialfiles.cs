using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenaid_IDE
{
    public partial class creatininitialfiles : Form
    {
        public creatininitialfiles()
        {
            InitializeComponent();
        }

        private void creatininitialfiles_Load(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(@"C:\greenaide");
                File.Create(@"C:\greenaide\defaultcode.txt");
                File.Create(@"C:\greenaide\codetype.cfg");
                fileslabel.Text = "Creating Folder: greenaide";
                progressBar1.Value = 10;
                Directory.CreateDirectory(@"C:\greenaide\projects");
                fileslabel.Text = "Creating Folder: greenaide/projects";
                progressBar1.Value = 20;
             
                File.Create(@"C:\greenaide\compshownum.cfg");
                fileslabel.Text = "Creating File: defaultcode.txt";
                progressBar1.Value = 40;
                File.Create(@"C:\greenaide\resxconfig.cfg");
                fileslabel.Text = "Creating File: resxconfig.cfg";
                progressBar1.Value = 50;
                File.Create(@"C:\greenaide\resyconfig.cfg");
                fileslabel.Text = "Creating File: resyconfig.cfg";
                progressBar1.Value = 60;
                File.Create(@"C:\greenaide\logs.log");
                fileslabel.Text = "Creating File: logs.log";
                progressBar1.Value = 70;
                File.Create(@"C:\greenaide\isprogins.dll");
                File.Create(@"C:\greenaide\oobe.dll");
                fileslabel.Text = "Creating File: oobe.dll";
                progressBar1.Value = 80;
                File.Create(@"C:\greenaide\currentdir.dll");
                File.Create(@"C:\greenaide\befunk.cfg");
                fileslabel.Text = "Creating File: currentdir.dll";
                progressBar1.Value = 90;
                File.Create(@"C:\greenaide\currentdirgrf.dll");
                fileslabel.Text = "Creating File: currentdirgff.dll";
                progressBar1.Value = 100;
                MessageBox.Show("Now, open the program again\n\nAhora, abre el programa otra vez", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong when creating the files", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
             
            }
           
            
            
        }
    }
}
