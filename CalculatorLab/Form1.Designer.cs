namespace CalculatorLab
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNoTextbox = new System.Windows.Forms.TextBox();
            this.SecondNoTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Two Numbers :";
            // 
            // FirstNoTextbox
            // 
            this.FirstNoTextbox.Location = new System.Drawing.Point(445, 168);
            this.FirstNoTextbox.Name = "FirstNoTextbox";
            this.FirstNoTextbox.Size = new System.Drawing.Size(237, 38);
            this.FirstNoTextbox.TabIndex = 2;
            // 
            // SecondNoTextbox
            // 
            this.SecondNoTextbox.Location = new System.Drawing.Point(445, 248);
            this.SecondNoTextbox.Name = "SecondNoTextbox";
            this.SecondNoTextbox.Size = new System.Drawing.Size(237, 38);
            this.SecondNoTextbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.show_sum);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "SUBTRACT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.show_difference);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SecondNoTextbox);
            this.Controls.Add(this.FirstNoTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNoTextbox;
        private System.Windows.Forms.TextBox SecondNoTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

