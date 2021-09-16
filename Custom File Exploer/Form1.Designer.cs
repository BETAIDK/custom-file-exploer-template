
namespace Custom_File_Exploer
{
    partial class Form1
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
            this.Back = new System.Windows.Forms.Button();
            this.Froward = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 34);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(51, 26);
            this.Back.TabIndex = 0;
            this.Back.Text = "<<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Froward
            // 
            this.Froward.Location = new System.Drawing.Point(69, 34);
            this.Froward.Name = "Froward";
            this.Froward.Size = new System.Drawing.Size(51, 26);
            this.Froward.TabIndex = 1;
            this.Froward.Text = ">>";
            this.Froward.UseVisualStyleBackColor = true;
            this.Froward.Click += new System.EventHandler(this.Froward_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(713, 38);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 2;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.Location = new System.Drawing.Point(126, 41);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(32, 13);
            this.Path.TabIndex = 3;
            this.Path.Text = "Path:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(164, 40);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(543, 20);
            this.search.TabIndex = 4;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Location = new System.Drawing.Point(12, 66);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(776, 372);
            this.WebBrowser.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File Exploer";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.open);
            this.Controls.Add(this.Froward);
            this.Controls.Add(this.Back);
            this.Name = "Form1";
            this.Text = "custom file exploer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Froward;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.Label label1;
    }
}

