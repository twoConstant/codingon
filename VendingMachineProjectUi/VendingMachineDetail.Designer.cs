namespace VendingMachineProjectUi
{
    partial class VendingMachineDetail
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button_vendingmachine_restart = new Button();
            button_user_restart = new Button();
            button_buy = new Button();
            textBox_stock = new TextBox();
            textBox_price = new TextBox();
            textBox_balance = new TextBox();
            textBox_creditcarde_accprice = new TextBox();
            textBox_limit = new TextBox();
            textBox_buy_quantity = new TextBox();
            textBox_total_price = new TextBox();
            radioButton_deposite = new RadioButton();
            radioButton_creditCard = new RadioButton();
            textBox_title = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 230);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 0;
            label1.Text = "자판기";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 351);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 1;
            label2.Text = "재고:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 433);
            label3.Name = "label3";
            label3.Size = new Size(75, 32);
            label3.TabIndex = 2;
            label3.Text = "가격: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(615, 230);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 3;
            label4.Text = "유저";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(615, 326);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 4;
            label5.Text = "예금잔액: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(616, 417);
            label6.Name = "label6";
            label6.Size = new Size(139, 32);
            label6.TabIndex = 5;
            label6.Text = "카드사용액:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(621, 510);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 6;
            label7.Text = "카드한도:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1106, 230);
            label8.Name = "label8";
            label8.Size = new Size(62, 32);
            label8.TabIndex = 7;
            label8.Text = "주문";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1106, 326);
            label9.Name = "label9";
            label9.Size = new Size(115, 32);
            label9.TabIndex = 8;
            label9.Text = "구매수량:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1106, 417);
            label10.Name = "label10";
            label10.Size = new Size(99, 32);
            label10.TabIndex = 9;
            label10.Text = "총 가격:";
            // 
            // button_vendingmachine_restart
            // 
            button_vendingmachine_restart.Location = new Point(271, 223);
            button_vendingmachine_restart.Name = "button_vendingmachine_restart";
            button_vendingmachine_restart.Size = new Size(150, 46);
            button_vendingmachine_restart.TabIndex = 10;
            button_vendingmachine_restart.Text = "새로고침";
            button_vendingmachine_restart.UseVisualStyleBackColor = true;
            // 
            // button_user_restart
            // 
            button_user_restart.Location = new Point(748, 223);
            button_user_restart.Name = "button_user_restart";
            button_user_restart.Size = new Size(150, 46);
            button_user_restart.TabIndex = 11;
            button_user_restart.Text = "새로고침";
            button_user_restart.UseVisualStyleBackColor = true;
            // 
            // button_buy
            // 
            button_buy.Location = new Point(1238, 223);
            button_buy.Name = "button_buy";
            button_buy.Size = new Size(150, 46);
            button_buy.TabIndex = 12;
            button_buy.Text = "구매하기";
            button_buy.UseVisualStyleBackColor = true;
            button_buy.Click += button_buy_Click;
            // 
            // textBox_stock
            // 
            textBox_stock.Location = new Point(271, 351);
            textBox_stock.Name = "textBox_stock";
            textBox_stock.Size = new Size(200, 39);
            textBox_stock.TabIndex = 13;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(269, 426);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(200, 39);
            textBox_price.TabIndex = 14;
            // 
            // textBox_balance
            // 
            textBox_balance.Location = new Point(748, 323);
            textBox_balance.Name = "textBox_balance";
            textBox_balance.Size = new Size(200, 39);
            textBox_balance.TabIndex = 15;
            // 
            // textBox_creditcarde_accprice
            // 
            textBox_creditcarde_accprice.Location = new Point(748, 410);
            textBox_creditcarde_accprice.Name = "textBox_creditcarde_accprice";
            textBox_creditcarde_accprice.Size = new Size(200, 39);
            textBox_creditcarde_accprice.TabIndex = 16;
            // 
            // textBox_limit
            // 
            textBox_limit.Location = new Point(748, 503);
            textBox_limit.Name = "textBox_limit";
            textBox_limit.Size = new Size(200, 39);
            textBox_limit.TabIndex = 17;
            // 
            // textBox_buy_quantity
            // 
            textBox_buy_quantity.Location = new Point(1238, 323);
            textBox_buy_quantity.Name = "textBox_buy_quantity";
            textBox_buy_quantity.Size = new Size(200, 39);
            textBox_buy_quantity.TabIndex = 18;
            textBox_buy_quantity.TextChanged += textBox_buy_quantity_TextChanged;
            // 
            // textBox_total_price
            // 
            textBox_total_price.Location = new Point(1238, 417);
            textBox_total_price.Name = "textBox_total_price";
            textBox_total_price.Size = new Size(200, 39);
            textBox_total_price.TabIndex = 19;
            // 
            // radioButton_deposite
            // 
            radioButton_deposite.AutoSize = true;
            radioButton_deposite.Location = new Point(1096, 510);
            radioButton_deposite.Name = "radioButton_deposite";
            radioButton_deposite.Size = new Size(93, 36);
            radioButton_deposite.TabIndex = 20;
            radioButton_deposite.TabStop = true;
            radioButton_deposite.Text = "예금";
            radioButton_deposite.UseVisualStyleBackColor = true;
            // 
            // radioButton_creditCard
            // 
            radioButton_creditCard.AutoSize = true;
            radioButton_creditCard.Location = new Point(1346, 508);
            radioButton_creditCard.Name = "radioButton_creditCard";
            radioButton_creditCard.Size = new Size(93, 36);
            radioButton_creditCard.TabIndex = 21;
            radioButton_creditCard.TabStop = true;
            radioButton_creditCard.Text = "카드";
            radioButton_creditCard.UseVisualStyleBackColor = true;
            // 
            // textBox_title
            // 
            textBox_title.Location = new Point(676, 46);
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(200, 39);
            textBox_title.TabIndex = 22;
            // 
            // VendingMachineDetail
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1631, 760);
            Controls.Add(textBox_title);
            Controls.Add(radioButton_creditCard);
            Controls.Add(radioButton_deposite);
            Controls.Add(textBox_total_price);
            Controls.Add(textBox_buy_quantity);
            Controls.Add(textBox_limit);
            Controls.Add(textBox_creditcarde_accprice);
            Controls.Add(textBox_balance);
            Controls.Add(textBox_price);
            Controls.Add(textBox_stock);
            Controls.Add(button_buy);
            Controls.Add(button_user_restart);
            Controls.Add(button_vendingmachine_restart);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VendingMachineDetail";
            Text = "VendingMachineDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button_vendingmachine_restart;
        private Button button_user_restart;
        private Button button_buy;
        private TextBox textBox_stock;
        private TextBox textBox_price;
        private TextBox textBox_balance;
        private TextBox textBox_creditcarde_accprice;
        private TextBox textBox_limit;
        private TextBox textBox_buy_quantity;
        private TextBox textBox_total_price;
        private RadioButton radioButton_deposite;
        private RadioButton radioButton_creditCard;
        private TextBox textBox_title;
    }
}