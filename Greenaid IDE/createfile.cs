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
    public partial class createfile : Form
    {
        public static string loc;
        public createfile()
        {
            InitializeComponent();
            button1.Enabled = false;
            this.customfiletype.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void nametextbox_TextChanged_1(object sender, EventArgs e)
        {

            locationtextbox.Text = @"C:\greenaide\projects\" + flodernametextbox.Text + @"\" + nametextbox.Text;
        }
        private void flodernametextbox_TextChanged(object sender, EventArgs e)
        {
            locationtextbox.Text = @"C:\greenaide\projects\" + flodernametextbox.Text + @"\" + nametextbox.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            loc = locationtextbox.Text;
            if (nametextbox.Text == "" && flodernametextbox.Text == "")
            {
                MessageBox.Show("Cant create a file with no name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                if (nametextbox.Text != "" && flodernametextbox.Text != "")
                {
                if (prjtypebox.SelectedItem == "Text File (.txt)")
                {
                    this.customfiletype.Visible = false;
                    button1.Enabled = true;
                    try
                    {
                        File.Create(loc + ".txt");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong when creating the file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                 
                    }
                    
                       

                    

                }
                if (prjtypebox.SelectedItem == "WebSite (.html)")
                {
                    this.customfiletype.Visible = false;
                    button1.Enabled = true;
                    try
                    {
                        File.Create(loc + ".html");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong when creating the file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
                        Application.Exit();
                      
                    }


                }
                if (prjtypebox.SelectedItem == "C# Console App (.cs)")
                {
                    this.customfiletype.Visible = false;
                    button1.Enabled = true;
                    try
                    {
                        File.Create(loc + ".cs");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong when creating the file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Application.Exit();

                    }


                }
                if (prjtypebox.SelectedItem == "Other File (.)")
                {
                    this.customfiletype.Visible = true;
                    button1.Enabled = true;
                    try
                    {
                        File.Create(loc + customfiletype.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong when creating the file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Application.Exit();

                    }


                }
                this.Close();
                }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void prjtypebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if (prjtypebox.SelectedItem != "Other File (.)")
            {
                this.customfiletype.Enabled = false;




            }
            if (prjtypebox.SelectedItem == "Other File (.)")
            {
                this.customfiletype.Enabled = true;



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new mainmenu().Show();
        }

        private void createfile_Load(object sender, EventArgs e)
        {

        }
    }
}
