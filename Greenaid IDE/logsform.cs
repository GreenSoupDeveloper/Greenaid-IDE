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
    public partial class logsform : Form
    {
        public logsform()
        {
            InitializeComponent();
            int x = Int32.Parse(File.ReadAllText(@"C:\greenaide\resxconfig.cfg"));
            int y = Int32.Parse(File.ReadAllText(@"C:\greenaide\resyconfig.cfg"));
            // mainTextBox.Text = File.ReadAllText(@"C:\greenaide\defaultcode.txt");
            Size = new Size(x, y);

            this.textBox1.Size = new System.Drawing.Size(x, y);
            textBox1.Text = File.ReadAllText(@"C:\greenaide\logs.log");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
