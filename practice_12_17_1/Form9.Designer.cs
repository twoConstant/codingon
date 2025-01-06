namespace practice_12_17_1
{
    partial class Form9
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
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_searc = new System.Windows.Forms.Button();
            this.textBox_extension = new System.Windows.Forms.TextBox();
            this.button_folderpathfinder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(11, 24);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(223, 21);
            this.textBox_path.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(11, 95);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 88);
            this.listBox1.TabIndex = 1;
            // 
            // button_searc
            // 
            this.button_searc.Location = new System.Drawing.Point(307, 187);
            this.button_searc.Margin = new System.Windows.Forms.Padding(2);
            this.button_searc.Name = "button_searc";
            this.button_searc.Size = new System.Drawing.Size(58, 27);
            this.button_searc.TabIndex = 2;
            this.button_searc.Text = "search";
            this.button_searc.UseVisualStyleBackColor = true;
            this.button_searc.Click += new System.EventHandler(this.button_searc_Click);
            // 
            // textBox_extension
            // 
            this.textBox_extension.Location = new System.Drawing.Point(134, 60);
            this.textBox_extension.Name = "textBox_extension";
            this.textBox_extension.Size = new System.Drawing.Size(100, 21);
            this.textBox_extension.TabIndex = 3;
            // 
            // button_folderpathfinder
            // 
            this.button_folderpathfinder.Location = new System.Drawing.Point(250, 39);
            this.button_folderpathfinder.Name = "button_folderpathfinder";
            this.button_folderpathfinder.Size = new System.Drawing.Size(75, 23);
            this.button_folderpathfinder.TabIndex = 4;
            this.button_folderpathfinder.Text = "find";
            this.button_folderpathfinder.UseVisualStyleBackColor = true;
            this.button_folderpathfinder.Click += new System.EventHandler(this.button_folderpathfinder_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 225);
            this.Controls.Add(this.button_folderpathfinder);
            this.Controls.Add(this.textBox_extension);
            this.Controls.Add(this.button_searc);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_path);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_searc;
        private System.Windows.Forms.TextBox textBox_extension;
        private System.Windows.Forms.Button button_folderpathfinder;
    }
}