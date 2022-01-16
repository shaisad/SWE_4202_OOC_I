namespace PharmacyManagement
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MedicineNameTextbox = new System.Windows.Forms.TextBox();
            this.MedicineIDTextbox = new System.Windows.Forms.TextBox();
            this.MedicineQuantityTextbox = new System.Windows.Forms.TextBox();
            this.MedicinePriceTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SalesIDTextbox = new System.Windows.Forms.TextBox();
            this.SalesQuantityTextbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.StockIDTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.InitialAccountBalanceTextbox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.show_medicine_index = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddMedicineOnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Account Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Initial Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Sales";
            // 
            // MedicineNameTextbox
            // 
            this.MedicineNameTextbox.Location = new System.Drawing.Point(111, 66);
            this.MedicineNameTextbox.Name = "MedicineNameTextbox";
            this.MedicineNameTextbox.Size = new System.Drawing.Size(100, 22);
            this.MedicineNameTextbox.TabIndex = 11;
            // 
            // MedicineIDTextbox
            // 
            this.MedicineIDTextbox.Location = new System.Drawing.Point(111, 105);
            this.MedicineIDTextbox.Name = "MedicineIDTextbox";
            this.MedicineIDTextbox.Size = new System.Drawing.Size(100, 22);
            this.MedicineIDTextbox.TabIndex = 12;
            // 
            // MedicineQuantityTextbox
            // 
            this.MedicineQuantityTextbox.Location = new System.Drawing.Point(111, 139);
            this.MedicineQuantityTextbox.Name = "MedicineQuantityTextbox";
            this.MedicineQuantityTextbox.Size = new System.Drawing.Size(100, 22);
            this.MedicineQuantityTextbox.TabIndex = 13;
            // 
            // MedicinePriceTextbox
            // 
            this.MedicinePriceTextbox.Location = new System.Drawing.Point(111, 179);
            this.MedicinePriceTextbox.Name = "MedicinePriceTextbox";
            this.MedicinePriceTextbox.Size = new System.Drawing.Size(100, 22);
            this.MedicinePriceTextbox.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Price";
            // 
            // SalesIDTextbox
            // 
            this.SalesIDTextbox.Location = new System.Drawing.Point(469, 66);
            this.SalesIDTextbox.Name = "SalesIDTextbox";
            this.SalesIDTextbox.Size = new System.Drawing.Size(100, 22);
            this.SalesIDTextbox.TabIndex = 16;
            // 
            // SalesQuantityTextbox
            // 
            this.SalesQuantityTextbox.Location = new System.Drawing.Point(469, 105);
            this.SalesQuantityTextbox.Name = "SalesQuantityTextbox";
            this.SalesQuantityTextbox.Size = new System.Drawing.Size(100, 22);
            this.SalesQuantityTextbox.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sell Medicine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SellMedicineOnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(777, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 24);
            this.button3.TabIndex = 24;
            this.button3.Text = "Show Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowStockOnClick);
            // 
            // StockIDTextbox
            // 
            this.StockIDTextbox.Location = new System.Drawing.Point(831, 69);
            this.StockIDTextbox.Name = "StockIDTextbox";
            this.StockIDTextbox.Size = new System.Drawing.Size(100, 22);
            this.StockIDTextbox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(748, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(746, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Stock";
            // 
            // InitialAccountBalanceTextbox
            // 
            this.InitialAccountBalanceTextbox.Location = new System.Drawing.Point(152, 355);
            this.InitialAccountBalanceTextbox.Name = "InitialAccountBalanceTextbox";
            this.InitialAccountBalanceTextbox.Size = new System.Drawing.Size(100, 22);
            this.InitialAccountBalanceTextbox.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(53, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 24);
            this.button4.TabIndex = 26;
            this.button4.Text = "Show Balance";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowBalanceOnClick);
            // 
            // show_medicine_index
            // 
            this.show_medicine_index.FormattingEnabled = true;
            this.show_medicine_index.ItemHeight = 16;
            this.show_medicine_index.Location = new System.Drawing.Point(895, 179);
            this.show_medicine_index.Name = "show_medicine_index";
            this.show_medicine_index.Size = new System.Drawing.Size(233, 148);
            this.show_medicine_index.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(748, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Medicine Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(748, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Medicine Quantity";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(25, 437);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(57, 16);
            this.BalanceLabel.TabIndex = 31;
            this.BalanceLabel.Text = "Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 619);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.show_medicine_index);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.InitialAccountBalanceTextbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StockIDTextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SalesQuantityTextbox);
            this.Controls.Add(this.SalesIDTextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MedicinePriceTextbox);
            this.Controls.Add(this.MedicineQuantityTextbox);
            this.Controls.Add(this.MedicineIDTextbox);
            this.Controls.Add(this.MedicineNameTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MedicineNameTextbox;
        private System.Windows.Forms.TextBox MedicineIDTextbox;
        private System.Windows.Forms.TextBox MedicineQuantityTextbox;
        private System.Windows.Forms.TextBox MedicinePriceTextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SalesIDTextbox;
        private System.Windows.Forms.TextBox SalesQuantityTextbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox StockIDTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox InitialAccountBalanceTextbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox show_medicine_index;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label BalanceLabel;
    }
}

