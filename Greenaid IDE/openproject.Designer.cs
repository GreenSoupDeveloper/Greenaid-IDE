
namespace Greenaid_IDE
{
    partial class openproject
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
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prjtypebox
            // 
            this.prjtypebox.FormattingEnabled = true;
            this.prjtypebox.Items.AddRange(new object[] {
            "WebSite (.html)",
            "Text File (.txt)",
            "C# Console App (.cs)"});
            this.prjtypebox.Location = new System.Drawing.Point(115, 151);
            this.prjtypebox.Name = "prjtypebox";
            this.prjtypebox.Size = new System.Drawing.Size(384, 21);
            this.prjtypebox.TabIndex = 19;
            this.prjtypebox.SelectedIndexChanged += new System.EventHandler(this.prjtypebox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Project Type:";
            // 
            // locationtextbox
            // 
            this.locationtextbox.Location = new System.Drawing.Point(115, 111);
            this.locationtextbox.Name = "locationtextbox";
            this.locationtextbox.Size = new System.Drawing.Size(384, 20);
            this.locationtextbox.TabIndex = 17;
            this.locationtextbox.Text = "C:\\greenaide\\projects\\";
            // 
            // labelabe
            // 
            this.labelabe.AutoSize = true;
            this.labelabe.Location = new System.Drawing.Point(36, 114);
            this.labelabe.Name = "labelabe";
            this.labelabe.Size = new System.Drawing.Size(51, 13);
            this.labelabe.TabIndex = 16;
            this.labelabe.Text = "Location:";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(115, 71);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(384, 20);
            this.nametextbox.TabIndex = 15;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Project name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Open a project";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
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
            this.Name = "openproject";
            this.Text = "Open a project";
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
        private System.Windows.Forms.Button button3;
    }
}