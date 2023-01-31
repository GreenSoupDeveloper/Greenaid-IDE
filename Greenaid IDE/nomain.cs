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
using System.Diagnostics;

namespace Greenaid_IDE
{
    public partial class nomain : Form
    {
        public static int tips = 1;

        
        public nomain()
        {
            InitializeComponent();
          
            new mainmenu().Show();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process.Start(@"C:\greenaide\logs.log");
            new logsform().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (tips == 1)
            {
                tipslabel.Text = "Fact: If you want to close the program\nclose this window";
              
            }
            if (tips == 2)
            {
                tipslabel.Text = "Fact: If you close this window\nthe entire program will close";
             

            }
            if (tips == 3)
            {
                tipslabel.Text = "Fact: Greenaid IDE is made in\nVisual Studio 2019";
      

            }
            if (tips == 4)
            {
                tipslabel.Text = "Fact: Greenaid IDE is compatible\nwith Windows Vista";
               

            }
            if (tips == 5)
            {
                tipslabel.Text = "Fact: You need Microsoft .NET\nFramework 4.0 to use this IDE";
        

            
            }
            if (tips == 6)
            {
                tipslabel.Text = "Fact: The creator of Greenaid IDE\nis GreenSoupDev";
              


            }
            if (tips == 7)
            {
                tipslabel.Text = "Fact: GreenSoupDev\nlikes Counter-Strike 1.6";
                


            }
            if (tips == 8)
            {
                tipslabel.Text = "Fact: Greenaid IDE dont uses the \nFastColoredBox package unlike SiCode IDE";
            


            }
            if (tips == 9)
            {
                tipslabel.Text = "Fact: Greenaid IDE in a start was going to be\na fork of SiCode IDE";
                tips = 0;


            }



            tips += 1;
           
        }
    }
}
