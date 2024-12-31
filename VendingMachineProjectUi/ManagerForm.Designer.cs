namespace VendingMachineProjectUi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_installation = new Button();
            button_delete = new Button();
            button_filling = new Button();
            button_fillings = new Button();
            button_vending_machine_detail = new Button();
            textBox_sales = new TextBox();
            textBox_stock = new TextBox();
            textBox_date_Installation = new TextBox();
            textBox_date_last_repair = new TextBox();
            textBox_total_sales = new TextBox();
            radioButton_get_all = new RadioButton();
            radioButton_repaire = new RadioButton();
            radioButton_replace = new RadioButton();
            button_fill_listBox = new Button();
            listBox_vendingmachine_names = new ListBox();
            textBox_selected_item = new TextBox();
            radioButton_filling_need = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 124);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "총 매출액 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(844, 331);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 1;
            label2.Text = "매출액 : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(844, 399);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 2;
            label3.Text = "재고 : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(844, 469);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 32);
            label4.TabIndex = 3;
            label4.Text = "설치일자 : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(844, 540);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 32);
            label5.TabIndex = 4;
            label5.Text = "수리일자 : ";
            // 
            // button_installation
            // 
            button_installation.Location = new Point(106, 269);
            button_installation.Margin = new Padding(6);
            button_installation.Name = "button_installation";
            button_installation.Size = new Size(150, 49);
            button_installation.TabIndex = 5;
            button_installation.Text = "설치";
            button_installation.UseVisualStyleBackColor = true;
            button_installation.Click += button_installation_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(106, 331);
            button_delete.Margin = new Padding(6);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(150, 49);
            button_delete.TabIndex = 6;
            button_delete.Text = "제거";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_filling
            // 
            button_filling.Location = new Point(106, 393);
            button_filling.Margin = new Padding(6);
            button_filling.Name = "button_filling";
            button_filling.Size = new Size(150, 49);
            button_filling.TabIndex = 7;
            button_filling.Text = "채우기";
            button_filling.UseVisualStyleBackColor = true;
            button_filling.Click += button_filling_Click;
            // 
            // button_fillings
            // 
            button_fillings.Location = new Point(106, 454);
            button_fillings.Margin = new Padding(6);
            button_fillings.Name = "button_fillings";
            button_fillings.Size = new Size(150, 49);
            button_fillings.TabIndex = 8;
            button_fillings.Text = "전체채우기";
            button_fillings.UseVisualStyleBackColor = true;
            button_fillings.Click += button_fillings_Click;
            // 
            // button_vending_machine_detail
            // 
            button_vending_machine_detail.Location = new Point(548, 269);
            button_vending_machine_detail.Margin = new Padding(6);
            button_vending_machine_detail.Name = "button_vending_machine_detail";
            button_vending_machine_detail.Size = new Size(216, 73);
            button_vending_machine_detail.TabIndex = 9;
            button_vending_machine_detail.Text = "자판기로 이동";
            button_vending_machine_detail.UseVisualStyleBackColor = true;
            button_vending_machine_detail.Click += button_vending_machine_detail_Click;
            // 
            // textBox_sales
            // 
            textBox_sales.Location = new Point(970, 322);
            textBox_sales.Margin = new Padding(6);
            textBox_sales.Name = "textBox_sales";
            textBox_sales.Size = new Size(196, 39);
            textBox_sales.TabIndex = 10;
            // 
            // textBox_stock
            // 
            textBox_stock.Location = new Point(970, 384);
            textBox_stock.Margin = new Padding(6);
            textBox_stock.Name = "textBox_stock";
            textBox_stock.Size = new Size(196, 39);
            textBox_stock.TabIndex = 11;
            // 
            // textBox_date_Installation
            // 
            textBox_date_Installation.Location = new Point(970, 463);
            textBox_date_Installation.Margin = new Padding(6);
            textBox_date_Installation.Name = "textBox_date_Installation";
            textBox_date_Installation.Size = new Size(196, 39);
            textBox_date_Installation.TabIndex = 12;
            // 
            // textBox_date_last_repair
            // 
            textBox_date_last_repair.Location = new Point(970, 533);
            textBox_date_last_repair.Margin = new Padding(6);
            textBox_date_last_repair.Name = "textBox_date_last_repair";
            textBox_date_last_repair.Size = new Size(196, 39);
            textBox_date_last_repair.TabIndex = 13;
            // 
            // textBox_total_sales
            // 
            textBox_total_sales.Location = new Point(268, 117);
            textBox_total_sales.Margin = new Padding(6);
            textBox_total_sales.Name = "textBox_total_sales";
            textBox_total_sales.Size = new Size(196, 39);
            textBox_total_sales.TabIndex = 14;
            // 
            // radioButton_get_all
            // 
            radioButton_get_all.AutoSize = true;
            radioButton_get_all.Location = new Point(548, 382);
            radioButton_get_all.Margin = new Padding(6);
            radioButton_get_all.Name = "radioButton_get_all";
            radioButton_get_all.Size = new Size(93, 36);
            radioButton_get_all.TabIndex = 15;
            radioButton_get_all.Text = "전체";
            radioButton_get_all.UseVisualStyleBackColor = true;
            // 
            // radioButton_repaire
            // 
            radioButton_repaire.AutoSize = true;
            radioButton_repaire.Location = new Point(548, 435);
            radioButton_repaire.Margin = new Padding(6);
            radioButton_repaire.Name = "radioButton_repaire";
            radioButton_repaire.Size = new Size(149, 36);
            radioButton_repaire.TabIndex = 16;
            radioButton_repaire.Text = "수리 필요";
            radioButton_repaire.UseVisualStyleBackColor = true;
            // 
            // radioButton_replace
            // 
            radioButton_replace.AutoSize = true;
            radioButton_replace.Location = new Point(548, 489);
            radioButton_replace.Margin = new Padding(6);
            radioButton_replace.Name = "radioButton_replace";
            radioButton_replace.Size = new Size(149, 36);
            radioButton_replace.TabIndex = 17;
            radioButton_replace.Text = "교체 필요";
            radioButton_replace.UseVisualStyleBackColor = true;
            // 
            // button_fill_listBox
            // 
            button_fill_listBox.Location = new Point(544, 606);
            button_fill_listBox.Margin = new Padding(6);
            button_fill_listBox.Name = "button_fill_listBox";
            button_fill_listBox.Size = new Size(150, 49);
            button_fill_listBox.TabIndex = 18;
            button_fill_listBox.Text = "조회";
            button_fill_listBox.UseVisualStyleBackColor = true;
            button_fill_listBox.Click += button_fill_listBox_Click;
            // 
            // listBox_vendingmachine_names
            // 
            listBox_vendingmachine_names.FormattingEnabled = true;
            listBox_vendingmachine_names.Location = new Point(296, 331);
            listBox_vendingmachine_names.Margin = new Padding(6);
            listBox_vendingmachine_names.Name = "listBox_vendingmachine_names";
            listBox_vendingmachine_names.Size = new Size(236, 324);
            listBox_vendingmachine_names.TabIndex = 19;
            listBox_vendingmachine_names.SelectedIndexChanged += listBox_vendingmachine_names_SelectedIndexChanged;
            // 
            // textBox_selected_item
            // 
            textBox_selected_item.BackColor = SystemColors.ControlLightLight;
            textBox_selected_item.Location = new Point(296, 265);
            textBox_selected_item.Margin = new Padding(6);
            textBox_selected_item.Name = "textBox_selected_item";
            textBox_selected_item.ReadOnly = true;
            textBox_selected_item.Size = new Size(196, 39);
            textBox_selected_item.TabIndex = 20;
            textBox_selected_item.TextChanged += textBox_selected_item_TextChanged;
            // 
            // radioButton_filling_need
            // 
            radioButton_filling_need.AutoSize = true;
            radioButton_filling_need.Location = new Point(548, 540);
            radioButton_filling_need.Name = "radioButton_filling_need";
            radioButton_filling_need.Size = new Size(149, 36);
            radioButton_filling_need.TabIndex = 17;
            radioButton_filling_need.Text = "재고 부족";
            radioButton_filling_need.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 960);
            Controls.Add(radioButton_filling_need);
            Controls.Add(textBox_selected_item);
            Controls.Add(listBox_vendingmachine_names);
            Controls.Add(button_fill_listBox);
            Controls.Add(radioButton_replace);
            Controls.Add(radioButton_repaire);
            Controls.Add(radioButton_get_all);
            Controls.Add(textBox_total_sales);
            Controls.Add(textBox_date_last_repair);
            Controls.Add(textBox_date_Installation);
            Controls.Add(textBox_stock);
            Controls.Add(textBox_sales);
            Controls.Add(button_vending_machine_detail);
            Controls.Add(button_fillings);
            Controls.Add(button_filling);
            Controls.Add(button_delete);
            Controls.Add(button_installation);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_installation;
        private Button button_delete;
        private Button button_filling;
        private Button button_fillings;
        private Button button_vending_machine_detail;
        private TextBox textBox_sales;
        private TextBox textBox_stock;
        private TextBox textBox_date_Installation;
        private TextBox textBox_date_last_repair;
        private TextBox textBox_total_sales;
        private RadioButton radioButton_get_all;
        private RadioButton radioButton_repaire;
        private RadioButton radioButton_replace;
        private Button button_fill_listBox;
        private ListBox listBox_vendingmachine_names;
        private TextBox textBox_selected_item;
        private RadioButton radioButton_filling_need;
    }
}
