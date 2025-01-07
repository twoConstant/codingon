namespace practice_12_17_1
{
    partial class Form11
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
            this.button_file_finder = new System.Windows.Forms.Button();
            this.textBox_content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_file_finder
            // 
            this.button_file_finder.Location = new System.Drawing.Point(574, 96);
            this.button_file_finder.Name = "button_file_finder";
            this.button_file_finder.Size = new System.Drawing.Size(115, 47);
            this.button_file_finder.TabIndex = 0;
            this.button_file_finder.Text = "파일검색";
            this.button_file_finder.UseVisualStyleBackColor = true;
            this.button_file_finder.Click += new System.EventHandler(this.button_file_finder_Click);
            // 
            // textBox_content
            // 
            this.textBox_content.Location = new System.Drawing.Point(20, 47);
            this.textBox_content.Multiline = true;
            this.textBox_content.Name = "textBox_content";
            this.textBox_content.Size = new System.Drawing.Size(530, 367);
            this.textBox_content.TabIndex = 1;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_content);
            this.Controls.Add(this.button_file_finder);
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_file_finder;
        private System.Windows.Forms.TextBox textBox_content;
    }
}