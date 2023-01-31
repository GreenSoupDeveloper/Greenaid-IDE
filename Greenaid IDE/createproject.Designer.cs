
namespace Greenaid_IDE
{
    partial class createproject
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
            this.label1 = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.labelabe = new System.Windows.Forms.Label();
            this.locationtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prjtypebox = new System.Windows.Forms.ComboBox();
            this.acceptbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customfiletype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Let\'s create a new project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Project name:";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(155, 70);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(384, 20);
            this.nametextbox.TabIndex = 8;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // labelabe
            // 
            this.labelabe.AutoSize = true;
            this.labelabe.Location = new System.Drawing.Point(37, 113);
            this.labelabe.Name = "labelabe";
            this.labelabe.Size = new System.Drawing.Size(51, 13);
            this.labelabe.TabIndex = 9;
            this.labelabe.Text = "Location:";
            // 
            // locationtextbox
            // 
            this.locationtextbox.Location = new System.Drawing.Point(155, 110);
            this.locationtextbox.Name = "locationtextbox";
            this.locationtextbox.Size = new System.Drawing.Size(384, 20);
            this.locationtextbox.TabIndex = 10;
            this.locationtextbox.Text = "C:\\greenaide\\projects\\";
            this.locationtextbox.TextChanged += new System.EventHandler(this.locationtextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Project Type:";
            // 
            // prjtypebox
            // 
            this.prjtypebox.FormattingEnabled = true;
            this.prjtypebox.Items.AddRange(new object[] {
            "WebSite (.html)",
            "Text File (.txt)",
            "C# Console App (.cs)",
            "Other File Type (.)"});
            this.prjtypebox.Location = new System.Drawing.Point(155, 150);
            this.prjtypebox.Name = "prjtypebox";
            this.prjtypebox.Size = new System.Drawing.Size(384, 21);
            this.prjtypebox.TabIndex = 12;
            this.prjtypebox.SelectedIndexChanged += new System.EventHandler(this.prjtypebox_SelectedIndexChanged);
            // 
            // acceptbutton
            // 
            this.acceptbutton.Location = new System.Drawing.Point(687, 404);
            this.acceptbutton.Name = "acceptbutton";
            this.acceptbutton.Size = new System.Drawing.Size(75, 23);
            this.acceptbutton.TabIndex = 13;
            this.acceptbutton.Text = "Accept";
            this.acceptbutton.UseVisualStyleBackColor = true;
            this.acceptbutton.Click += new System.EventHandler(this.acceptbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customfiletype
            // 
            this.customfiletype.Location = new System.Drawing.Point(155, 190);
            this.customfiletype.Name = "customfiletype";
            this.customfiletype.Size = new System.Drawing.Size(384, 20);
            this.customfiletype.TabIndex = 16;
            this.customfiletype.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Type file extention:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "For example: \'.mk\'\r\n";
            // 
            // createproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customfiletype);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.acceptbutton);
            this.Controls.Add(this.prjtypebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationtextbox);
            this.Controls.Add(this.labelabe);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "createproject";
            this.Text = "Create a new project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label labelabe;
        private System.Windows.Forms.TextBox locationtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox prjtypebox;
        private System.Windows.Forms.Button acceptbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox customfiletype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}