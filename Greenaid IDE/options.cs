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
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
            int x = Int32.Parse(File.ReadAllText(@"C:\greenaide\resxconfig.cfg"));
            int y = Int32.Parse(File.ReadAllText(@"C:\greenaide\resyconfig.cfg"));

            resolutionxtext.Text = x.ToString();
            resolutionytext.Text = y.ToString();

            if (File.ReadAllText(@"C:\greenaide\befunk.cfg") == "experimental functions: true")
            {
                checkBox1.Checked = true;
            }
            if (File.ReadAllText(@"C:\greenaide\befunk.cfg") == "experimental functions: false")
            {
                checkBox1.Checked = false;

            }
        }

        private void acceptbutton_Click(object sender, EventArgs e)
        {
            var resx = resolutionxtext.Text;
            var resy = resolutionytext.Text;

            File.WriteAllText(@"C:\greenaide\resxconfig.cfg", resx);
            File.WriteAllText(@"C:\greenaide\resyconfig.cfg", resy);
            MessageBox.Show("To apply the changes, you have to reset Greenaid IDE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All the Greenaid IDE Data is going to be reset right now\nbut the projects are safe so calm down", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            try
            {
               

                File.Delete(@"C:\greenaide\defaultcode.txt");

                File.Delete(@"C:\greenaide\resxconfig.cfg");

                File.Delete(@"C:\greenaide\resyconfig.cfg");

                File.Delete(@"C:\greenaide\logs.log");

                File.Delete(@"C:\greenaide\oobe.dll");

                File.Delete(@"C:\greenaide\currentdir.dll");

                File.Delete(@"C:\greenaide\currentdirgrf.dll");
                File.Delete(@"C:\greenaide\befunk.cfg");
                File.Delete(@"C:\greenaide\codetype.cfg");
                File.Delete(@"C:\greenaide\compshownum.cfg");



                File.Create(@"C:\greenaide\compshownum.cfg");
                File.Create(@"C:\greenaide\defaultcode.txt");
             
                File.Create(@"C:\greenaide\resxconfig.cfg");
               
                File.Create(@"C:\greenaide\resyconfig.cfg");
              
                File.Create(@"C:\greenaide\logs.log");
                File.Create(@"C:\greenaide\befunk.cfg");


                File.Create(@"C:\greenaide\oobe.dll");
              
                File.Create(@"C:\greenaide\currentdir.dll");
             
                File.Create(@"C:\greenaide\currentdirgrf.dll");
                File.Create(@"C:\greenaide\codetype.cfg");

                MessageBox.Show("Greenaid IDE has been reset successfully, Now open the program again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong when reseting Greenaid IDE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
                Application.Exit();
            
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                File.WriteAllText(@"C:\greenaide\befunk.cfg", "experimental functions: true");
            }
            if (checkBox1.Checked == false)
            {
                File.WriteAllText(@"C:\greenaide\befunk.cfg", "experimental functions: false");
            }
        }
    }
}
