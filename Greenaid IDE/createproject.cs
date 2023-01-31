using System;
using System.IO;
using Greenaid_IDE;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Greenaid_IDE
{
    public partial class createproject : Form
    {
        public static string projectname;
        public static string location;
        public static string name;
        public static string namenull;
        public createproject()
        {
            InitializeComponent();
            nametextbox.Text = "NewProject";
            locationtextbox.Text = @"C:\greenaide\projects\" + nametextbox.Text;
           
            
                acceptbutton.Enabled = false;
            customfiletype.Enabled = false;

        }

        private void locationtextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {
     
            locationtextbox.Text = @"C:\greenaide\projects\" + nametextbox.Text;
           
        }

        private void acceptbutton_Click(object sender, EventArgs e)
        {
         
            if (prjtypebox.Text == "WebSite (.html)")
            {
                customfiletype.Enabled = false;
                try
                {
                    File.WriteAllText(@"C:\greenaide\defaultcode.txt", GlobalTexts.DefaultWebsiteCode);
                    Directory.CreateDirectory(locationtextbox.Text);
                    File.Create(locationtextbox.Text + @"\" + nametextbox.Text + ".html");
                    File.Create(locationtextbox.Text + @"\" + nametextbox.Text + ".grf");
                    location = locationtextbox.Text + @"\" + nametextbox.Text + ".grf";
                    name = nametextbox.Text + ".html";
                    namenull = nametextbox.Text;
                    File.WriteAllText(@"C:\greenaide\currentdir.dll", locationtextbox.Text + @"\" + nametextbox.Text + ".html");
                    File.WriteAllText(@"C:\greenaide\currentdirgrf.dll", locationtextbox.Text + @"\" + nametextbox.Text + ".grf");

                    //  File.WriteAllText(locationtextbox.Text + @"\" + nametextbox.Text + ".grf", locationtextbox.Text + @"\" + nametextbox.Text + ".html");



                    Form1.savedir = locationtextbox.Text + @"\" + nametextbox.Text + ".html";
                    MessageBox.Show("To finish creating the project, you have to reset Greenaid IDE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(@"C:\greenaide\projects\" + nametextbox.Text, "explorer.exe");
                    Application.Exit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Project Created!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                 
                }
               
            }
            if (prjtypebox.Text == "Text File (.txt)")
            {
                customfiletype.Enabled = false;
                try
                {
                    File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
                    Directory.CreateDirectory(locationtextbox.Text);
                    File.Create(locationtextbox.Text + @"\" + nametextbox.Text + ".txt");
                    File.Create(locationtextbox.Text + @"\" + nametextbox.Text + ".grf");

                    location = locationtextbox.Text + @"\" + nametextbox.Text + ".grf";
                    name = nametextbox.Text + ".txt";
                    namenull = nametextbox.Text;
                    File.WriteAllText(@"C:\greenaide\currentdir.dll", locationtextbox.Text + @"\" + nametextbox.Text + ".txt");
                    File.WriteAllText(@"C:\greenaide\currentdirgrf.dll", locationtextbox.Text + @"\" + nametextbox.Text + ".grf");
                    // File.WriteAllText(locationtextbox.Text + @"\" + nametextbox.Text + ".grf", locationtextbox.Text + @"\" + nametextbox.Text + ".txt");
                    Form1.savedir = locationtextbox.Text + @"\" + nametextbox.Text + ".txt";
                    MessageBox.Show("To finish creating the project, you have to reset Greenaid IDE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(@"C:\greenaide\projects\" + nametextbox.Text, "explorer.exe");
                    Application.Exit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Project Created!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                  
                }
               
            }
            if (prjtypebox.Text == "C# Console App (.cs)")
            {
                customfiletype.Enabled = false;
                try
                {
                    File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
                    Directory.CreateDirectory(locationtextbox.Text);
                    File.Create(locationtextbox.Text + @"\" + nametextbox.Text + ".cs");
                    File.Create(locationtextbox.Text + @"\" + nametextbox.Text + ".grf");

                    location = locationtextbox.Text + @"\" + nametextbox.Text + ".grf";
                    name = nametextbox.Text + ".cs";
                    namenull = nametextbox.Text;
                    File.WriteAllText(@"C:\greenaide\currentdir.dll", locationtextbox.Text + @"\" + nametextbox.Text + ".cs");
                    File.WriteAllText(@"C:\greenaide\currentdirgrf.dll", locationtextbox.Text + @"\" + nametextbox.Text + ".grf");
               
                    Form1.savedir = locationtextbox.Text + @"\" + nametextbox.Text + ".cs";
                    MessageBox.Show("Project Created!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(@"C:\greenaide\projects\" + nametextbox.Text, "explorer.exe");
                    Application.Exit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong when creating the project", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                   
                }

            }
            if (prjtypebox.Text == "Other File Type (.)")
            {
                customfiletype.Enabled = true;
                try
                {
                    File.WriteAllText(@"C:\greenaide\defaultcode.txt", "");
                    Directory.CreateDirectory(locationtextbox.Text);
                    File.Create(locationtextbox.Text + @"\" + nametextbox.Text + customfiletype.Text);
                    File.Create(locationtextbox.Text + @"\" + nametextbox.Text + ".grf");

                    location = locationtextbox.Text + @"\" + nametextbox.Text + ".grf";
                    name = nametextbox.Text + customfiletype.Text;
                    namenull = nametextbox.Text;
                    File.WriteAllText(@"C:\greenaide\currentdir.dll", locationtextbox.Text + @"\" + nametextbox.Text + customfiletype.Text);
                    File.WriteAllText(@"C:\greenaide\currentdirgrf.dll", locationtextbox.Text + @"\" + nametextbox.Text + ".grf");

                    Form1.savedir = locationtextbox.Text + @"\" + nametextbox.Text + customfiletype.Text;
                    MessageBox.Show("Project Created!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(@"C:\greenaide\projects\" + nametextbox.Text, "explorer.exe");
                    Application.Exit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong when creating the project", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();

                }

            }
           


            new Form1().Show();
            this.Close();
        }

        private void prjtypebox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (prjtypebox.Text != "" && nametextbox.Text != "")
            {
                acceptbutton.Enabled = true;
            }
            if (prjtypebox.Text == "Other File Type (.)")
            {
                customfiletype.Enabled = true;
            }
            if (prjtypebox.Text != "Other File Type (.)")
            {
                customfiletype.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new mainmenu().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
