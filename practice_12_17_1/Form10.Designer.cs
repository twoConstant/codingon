namespace practice_12_17_1
{
    partial class Form10
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
            this.button_race_start = new System.Windows.Forms.Button();
            this.listBox_results = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_race_start
            // 
            this.button_race_start.Location = new System.Drawing.Point(582, 83);
            this.button_race_start.Name = "button_race_start";
            this.button_race_start.Size = new System.Drawing.Size(133, 62);
            this.button_race_start.TabIndex = 0;
            this.button_race_start.Text = "start";
            this.button_race_start.UseVisualStyleBackColor = true;
            this.button_race_start.Click += new System.EventHandler(this.button_race_start_Click);
            // 
            // listBox_results
            // 
            this.listBox_results.FormattingEnabled = true;
            this.listBox_results.ItemHeight = 24;
            this.listBox_results.Location = new System.Drawing.Point(23, 43);
            this.listBox_results.Name = "listBox_results";
            this.listBox_results.Size = new System.Drawing.Size(535, 364);
            this.listBox_results.TabIndex = 1;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_results);
            this.Controls.Add(this.button_race_start);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_race_start;
        private System.Windows.Forms.ListBox listBox_results;
    }
}