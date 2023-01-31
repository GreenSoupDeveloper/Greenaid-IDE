
namespace Greenaid_IDE
{
    partial class createfile
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
            this.prjtypebox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locationtextbox = new System.Windows.Forms.TextBox();
            this.labelabe = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flodernametextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customfiletype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prjtypebox
            // 
            this.prjtypebox.FormattingEnabled = true;
            this.prjtypebox.Items.AddRange(new object[] {
            "WebSite (.html)",
            "Text File (.txt)",
            "C# Console App (.cs)",
            "Other File (.)"});
            this.prjtypebox.Location = new System.Drawing.Point(163, 176);
            this.prjtypebox.Name = "prjtypebox";
            this.prjtypebox.Size = new System.Drawing.Size(384, 21);
            this.prjtypebox.TabIndex = 19;
            this.prjtypebox.SelectedIndexChanged += new System.EventHandler(this.prjtypebox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "File Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // locationtextbox
            // 
            this.locationtextbox.Location = new System.Drawing.Point(163, 143);
            this.locationtextbox.Name = "locationtextbox";
            this.locationtextbox.Size = new System.Drawing.Size(384, 20);
            this.locationtextbox.TabIndex = 17;
            this.locationtextbox.Text = "C:\\greenaide\\projects\\";
            // 
            // labelabe
            // 
            this.labelabe.AutoSize = true;
            this.labelabe.Location = new System.Drawing.Point(37, 146);
            this.labelabe.Name = "labelabe";
            this.labelabe.Size = new System.Drawing.Size(51, 13);
            this.labelabe.TabIndex = 16;
            this.labelabe.Text = "Location:";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(163, 71);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(384, 20);
            this.nametextbox.TabIndex = 15;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "File name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Create a new file";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flodernametextbox
            // 
            this.flodernametextbox.Location = new System.Drawing.Point(163, 108);
            this.flodernametextbox.Name = "flodernametextbox";
            this.flodernametextbox.Size = new System.Drawing.Size(384, 20);
            this.flodernametextbox.TabIndex = 22;
            this.flodernametextbox.TextChanged += new System.EventHandler(this.flodernametextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Project folder name:";
            // 
            // customfiletype
            // 
            this.customfiletype.Location = new System.Drawing.Point(163, 210);
            this.customfiletype.Name = "customfiletype";
            this.customfiletype.Size = new System.Drawing.Size(384, 20);
            this.customfiletype.TabIndex = 25;
            this.customfiletype.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Type file extention:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "For example: \'.asm\'\r\n";
            // 
            // createfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customfiletype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flodernametextbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prjtypebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationtextbox);
            this.Controls.Add(this.labelabe);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "createfile";
            this.Text = "Create a new file";
            this.Load += new System.EventHandler(this.createfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox prjtypebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationtextbox;
        private System.Windows.Forms.Label labelabe;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox flodernametextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customfiletype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}