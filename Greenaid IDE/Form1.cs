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
using FastColoredTextBoxNS;



namespace Greenaid_IDE
{
    public partial class Form1 : Form
    {

        public static string maintext;
        public static string savedir;
        public static bool isnewtext;
        public static string defaultcode = File.ReadAllText(@"C:\greenaide\defaultcode.txt");
        public OpenFileDialog f = new OpenFileDialog();

        public Form1()
        {




            InitializeComponent();


            mainTextBox.Text = "";

            int x = Int32.Parse(File.ReadAllText(@"C:\greenaide\resxconfig.cfg"));
                int y = Int32.Parse(File.ReadAllText(@"C:\greenaide\resyconfig.cfg"));
                // mainTextBox.Text = File.ReadAllText(@"C:\greenaide\defaultcode.txt");
               

            this.mainTextBox.Size = Screen.PrimaryScreen.Bounds.Size;

            if (mainmenu.text != "")
            {
                mainTextBox.Text = mainmenu.text;
            }
            if (defaultcode != "")
            {
                mainTextBox.Text = defaultcode;
            }

            if (File.ReadAllText(@"C:\greenaide\befunk.cfg") == "experimental functions: false" || File.ReadAllText(@"C:\greenaide\befunk.cfg") == "")
            {
                if (File.ReadAllText(@"C:\greenaide\compshownum.cfg") == "1")
                {
                    menuStrip1.Items.Remove(compilerToolStripMenuItem);
                }
                if (File.ReadAllText(@"C:\greenaide\compshownum.cfg") == "3")
                {
                    menuStrip1.Items.Remove(compilerToolStripMenuItem);
                }

            }

            if (File.ReadAllText(@"C:\greenaide\befunk.cfg") == "experimental functions: true")
            {
                if (File.ReadAllText(@"C:\greenaide\compshownum.cfg") == "1")
                {
                    menuStrip1.Items.Remove(compilerToolStripMenuItem);
                }
                if (File.ReadAllText(@"C:\greenaide\compshownum.cfg") == "3")
                {
                   
                }
               

            }


           


        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
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
                    this.Close();
                }
                if (!f.FileName.EndsWith(".cs"))
                {
                    var filedirrr = File.ReadAllText(f.FileName);
                    Form1.savedir = f.FileName;
                    File.WriteAllText(@"C:\greenaide\compshownum.cfg", "1");
                    mainmenu.text = filedirrr;
                    new Form1().Show();
                    this.Close();
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
                        this.Close();
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
                        this.Close();
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
                        this.Close();
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

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
          



        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new options().Show();
        }

        private void closeGreenaidIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(savedir, mainTextBox.Text);

        }

      

        private void saveFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (File.Exists(mainmenu.fileedir))
            {
                File.WriteAllText(mainmenu.fileedir, mainTextBox.Text);

            }
            if (File.Exists(savedir))
            {
                File.WriteAllText(savedir, mainTextBox.Text);
            }


            if (!File.Exists(mainmenu.fileedir))
            {
                if (isnewtext == true)
                {
                    OpenFileDialog f = new OpenFileDialog();
                    f.Filter = "Any file(*.*) | *.*";
                    f.ShowDialog();

                    var dir = f.FileName;

                    File.WriteAllText(dir, mainTextBox.Text);

                    mainmenu.fileedir = f.FileName;
                }

            }
        }

     

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new about().Show();
        }

        private void openProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new openproject().Show();
        
        }

        private void openFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
           
        }

        private void createProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new createproject().Show();
         
        }

        private void createFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new createfile().Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong when saving the file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
         
        }

        private void returnToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new mainmenu().Show();
        }

        private void seeErrorsLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new logsform().Show();
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
