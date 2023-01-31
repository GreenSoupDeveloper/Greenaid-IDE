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
   
    public partial class openproject : Form
    {
        public static string loc;
       
     
        public openproject()
        {
            InitializeComponent();
            button1.Enabled = false;
            mainmenu.fileedir = "";
        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {
            locationtextbox.Text = @"C:\greenaide\projects\" + nametextbox.Text + @"\" + nametextbox.Text; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loc = locationtextbox.Text;
            if (!File.Exists(loc + ".grf"))
            {
                MessageBox.Show("This project doesnt exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (File.Exists(loc + ".grf"))
            {
               



              

                if (prjtypebox.SelectedItem == "Text File (.txt)")
                {
                    if (File.Exists(loc + ".txt"))
                    {
                        File.WriteAllText(@"C:\greenaide\compshownum.cfg", "1");
                        File.WriteAllText(loc + ".grf", loc + ".txt");
                    }
                    
                }
                if (prjtypebox.SelectedItem == "WebSite (.html)")
                {
                    if (File.Exists(loc + ".html"))
                    {
                        File.WriteAllText(@"C:\greenaide\compshownum.cfg", "2");
                        File.WriteAllText(loc + ".grf", loc + ".html");
                    }
                  
                    
                }
                if (prjtypebox.SelectedItem == "C# Console App (.cs)")
                {
                    if (File.Exists(loc + ".cs"))
                    {
                        File.WriteAllText(@"C:\greenaide\compshownum.cfg", "3");
                        File.WriteAllText(loc + ".grf", loc + ".cs");
                    }
                  
                    
                }
                if (prjtypebox.SelectedItem == "WebSite (.html)" && File.Exists(loc + ".html"))
                {
                    File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
                    var locplus = loc + ".grf";
                    var location = File.ReadAllText(loc + ".grf");



                    if (locplus.EndsWith(".grf"))
                    {

                        Form1.savedir = File.ReadAllText(loc + ".grf");

                        mainmenu.text = File.ReadAllText(location);
                        new Form1().Show();
                        mainmenu.dir = "";
                        mainmenu.text = "";
                        this.Close();
                    }

                }
                if (prjtypebox.SelectedItem == "Text File (.txt)" && File.Exists(loc + ".txt"))
                {
                    File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
                    var locplus = loc + ".grf";
                    var location = File.ReadAllText(loc + ".grf");



                    if (locplus.EndsWith(".grf"))
                    {

                        Form1.savedir = File.ReadAllText(loc + ".grf");

                        mainmenu.text = File.ReadAllText(location);
                        new Form1().Show();
                        mainmenu.dir = "";
                        mainmenu.text = "";
                            this.Close();
                    }

                    
                }
                if (prjtypebox.SelectedItem == "C# Console App (.cs)" && File.Exists(loc + ".cs"))
                {
                    File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
                    var locplus = loc + ".grf";
                    var location = File.ReadAllText(loc + ".grf");



                    if (locplus.EndsWith(".grf"))
                    {

                        Form1.savedir = File.ReadAllText(loc + ".grf");

                        mainmenu.text = File.ReadAllText(location);
                        new Form1().Show();
                        mainmenu.dir = "";
                        mainmenu.text = "";
                        this.Close();
                    }


                }
                if (prjtypebox.SelectedItem == "WebSite (.html)" && !File.Exists(loc + ".html") || prjtypebox.SelectedItem == "Text File (.txt)" && !File.Exists(loc + ".txt") || prjtypebox.SelectedItem == "C# Console App (.cs)" && !File.Exists(loc + ".cs"))
                {
                    MessageBox.Show("This project doesnt exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new mainmenu().Show();
        }

        private void prjtypebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
