using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastColoredTextBoxNS;
using System.Windows.Forms;

namespace Greenaid_IDE
{
    public partial class mainmenu : Form
    {
        public static string dir;
        public static string fileedir;
        public static string text;
        public OpenFileDialog f = new OpenFileDialog();
        public mainmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
            dir = "";
            text = "";
            new createproject().Show();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               

                f.Filter = "Any file(*.*) | *.*|Greenaid IDE Project Files(.grf) | *.grf";
                f.ShowDialog();

                if (f.FileName.EndsWith(".cs"))
                {
                    var filedirrr = File.ReadAllText(f.FileName);
                    Form1.savedir = f.FileName;
                    File.WriteAllText(@"C:\greenaide\compshownum.cfg", "3");
                    mainmenu.text = filedirrr;
                    new Form1().Show();
        
                }
                if (!f.FileName.EndsWith(".cs"))
                {
                    var filedirrr = File.ReadAllText(f.FileName);
                    Form1.savedir = f.FileName;
                    File.WriteAllText(@"C:\greenaide\compshownum.cfg", "1");
                    mainmenu.text = filedirrr;
                    new Form1().Show();
          
                }
                if (f.FileName.EndsWith(".grf"))
                {

                    var filedirrr = File.ReadAllText(f.FileName);
                    if (filedirrr.EndsWith(".txt"))
                    {
                        File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
                        Form1.savedir = filedirrr;

                        mainmenu.text = File.ReadAllText(filedirrr);
                        File.WriteAllText(@"C:\greenaide\compshownum.cfg", "1");
                        new Form1().Show();
                        mainmenu.dir = "";
                        mainmenu.text = "";
                    
                    }
                    if (filedirrr.EndsWith(".html"))
                    {
                        File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
                        Form1.savedir = filedirrr;

                        mainmenu.text = File.ReadAllText(filedirrr);
                        File.WriteAllText(@"C:\greenaide\compshownum.cfg", "1");
                        new Form1().Show();
                        mainmenu.dir = "";
                        mainmenu.text = "";
                
                    }
                    if (filedirrr.EndsWith(".cs"))
                    {
                        File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
                        Form1.savedir = filedirrr;

                        mainmenu.text = File.ReadAllText(filedirrr);
                        File.WriteAllText(@"C:\greenaide\compshownum.cfg", "3");
                        new Form1().Show();
                        mainmenu.dir = "";
                        mainmenu.text = "";
             
                    }

                }

             

            }
            catch (Exception)
            {

                if (!f.FileName.EndsWith(".grf"))
                {
                    MessageBox.Show("Something went wrong when opening the file/project", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            new options().Show();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.isnewtext = true;
            new Form1().Show();
           
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void mainmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
