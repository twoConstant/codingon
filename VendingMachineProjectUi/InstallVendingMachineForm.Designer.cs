namespace VendingMachineProjectUi
{
    partial class InstallVendingMachineForm
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
            textBox_vendingmachine_name = new TextBox();
            textBox_drink_price = new TextBox();
            label_vendingmachine_name = new Label();
            label2 = new Label();
            button_confirm = new Button();
            SuspendLayout();
            // 
            // textBox_vendingmachine_name
            // 
            textBox_vendingmachine_name.Location = new Point(169, 196);
            textBox_vendingmachine_name.Name = "textBox_vendingmachine_name";
            textBox_vendingmachine_name.Size = new Size(200, 39);
            textBox_vendingmachine_name.TabIndex = 0;
            // 
            // textBox_drink_price
            // 
            textBox_drink_price.Location = new Point(567, 192);
            textBox_drink_price.Name = "textBox_drink_price";
            textBox_drink_price.Size = new Size(200, 39);
            textBox_drink_price.TabIndex = 1;
            // 
            // label_vendingmachine_name
            // 
            label_vendingmachine_name.AutoSize = true;
            label_vendingmachine_name.Location = new Point(41, 194);
            label_vendingmachine_name.Name = "label_vendingmachine_name";
            label_vendingmachine_name.Size = new Size(123, 32);
            label_vendingmachine_name.TabIndex = 2;
            label_vendingmachine_name.Text = "자판기명: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 197);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 3;
            label2.Text = "음료 가격: ";
            // 
            // button_confirm
            // 
            button_confirm.Location = new Point(617, 313);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(150, 46);
            button_confirm.TabIndex = 4;
            button_confirm.Text = "생성";
            button_confirm.UseVisualStyleBackColor = true;
            button_confirm.Click += button_confirm_Click;
            // 
            // InstallVendingMachineForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_confirm);
            Controls.Add(label2);
            Controls.Add(label_vendingmachine_name);
            Controls.Add(textBox_drink_price);
            Controls.Add(textBox_vendingmachine_name);
            Name = "InstallVendingMachineForm";
            Text = "InstallVendingMachineForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_vendingmachine_name;
        private TextBox textBox_drink_price;
        private Label label_vendingmachine_name;
        private Label label2;
        private Button button_confirm;
    }
}