
namespace Greenaid_IDE
{
    partial class options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resolutionytext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resolutionxtext = new System.Windows.Forms.TextBox();
            this.acceptbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            // 
            // resolutionytext
            // 
            this.resolutionytext.Location = new System.Drawing.Point(223, 68);
            this.resolutionytext.Name = "resolutionytext";
            this.resolutionytext.Size = new System.Drawing.Size(63, 20);
            this.resolutionytext.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Screen resolution: ";
            // 
            // resolutionxtext
            // 
            this.resolutionxtext.Location = new System.Drawing.Point(139, 68);
            this.resolutionxtext.Name = "resolutionxtext";
            this.resolutionxtext.Size = new System.Drawing.Size(63, 20);
            this.resolutionxtext.TabIndex = 6;
            // 
            // acceptbutton
            // 
            this.acceptbutton.Location = new System.Drawing.Point(690, 401);
            this.acceptbutton.Name = "acceptbutton";
            this.acceptbutton.Size = new System.Drawing.Size(75, 23);
            this.acceptbutton.TabIndex = 11;
            this.acceptbutton.Text = "Accept";
            this.acceptbutton.UseVisualStyleBackColor = true;
            this.acceptbutton.Click += new System.EventHandler(this.acceptbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Greenaid options";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset Greenaid data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Experimental Functions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "The Experimental functions are Beta addings that\r\n are\'nt finished, that are goin" +
    "g to be included in later\r\nversions of Greenaid IDE\r\n";
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.acceptbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resolutionytext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resolutionxtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resolutionytext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resolutionxtext;
        private System.Windows.Forms.Button acceptbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
    }
}