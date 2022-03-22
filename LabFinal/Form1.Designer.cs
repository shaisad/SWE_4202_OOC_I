namespace LabFinal
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
            this.SearchIDTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.student_listbox = new System.Windows.Forms.ListBox();
            this.AttendanceLabel = new System.Windows.Forms.Label();
            this.Quiz1Label = new System.Windows.Forms.Label();
            this.Quiz2Label = new System.Windows.Forms.Label();
            this.Quiz3Label = new System.Windows.Forms.Label();
            this.Quiz4Label = new System.Windows.Forms.Label();
            this.QuizTotalLabel = new System.Windows.Forms.Label();
            this.MidLabel = new System.Windows.Forms.Label();
            this.VivaLabel = new System.Windows.Forms.Label();
            this.FinalLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.DevelopedByLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchIDTextbox
            // 
            this.SearchIDTextbox.Location = new System.Drawing.Point(969, 61);
            this.SearchIDTextbox.Name = "SearchIDTextbox";
            this.SearchIDTextbox.Size = new System.Drawing.Size(297, 38);
            this.SearchIDTextbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(893, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.search_id_on_click);
            // 
            // student_listbox
            // 
            this.student_listbox.FormattingEnabled = true;
            this.student_listbox.ItemHeight = 31;
            this.student_listbox.Location = new System.Drawing.Point(42, 42);
            this.student_listbox.Name = "student_listbox";
            this.student_listbox.Size = new System.Drawing.Size(725, 531);
            this.student_listbox.TabIndex = 2;
            // 
            // AttendanceLabel
            // 
            this.AttendanceLabel.AutoSize = true;
            this.AttendanceLabel.Location = new System.Drawing.Point(897, 268);
            this.AttendanceLabel.Name = "AttendanceLabel";
            this.AttendanceLabel.Size = new System.Drawing.Size(174, 32);
            this.AttendanceLabel.TabIndex = 3;
            this.AttendanceLabel.Text = "Attendance :";
            // 
            // Quiz1Label
            // 
            this.Quiz1Label.AutoSize = true;
            this.Quiz1Label.Location = new System.Drawing.Point(897, 328);
            this.Quiz1Label.Name = "Quiz1Label";
            this.Quiz1Label.Size = new System.Drawing.Size(111, 32);
            this.Quiz1Label.TabIndex = 4;
            this.Quiz1Label.Text = "Quiz 1 :";
            // 
            // Quiz2Label
            // 
            this.Quiz2Label.AutoSize = true;
            this.Quiz2Label.Location = new System.Drawing.Point(897, 387);
            this.Quiz2Label.Name = "Quiz2Label";
            this.Quiz2Label.Size = new System.Drawing.Size(111, 32);
            this.Quiz2Label.TabIndex = 5;
            this.Quiz2Label.Text = "Quiz 2 :";
            // 
            // Quiz3Label
            // 
            this.Quiz3Label.AutoSize = true;
            this.Quiz3Label.Location = new System.Drawing.Point(897, 440);
            this.Quiz3Label.Name = "Quiz3Label";
            this.Quiz3Label.Size = new System.Drawing.Size(111, 32);
            this.Quiz3Label.TabIndex = 6;
            this.Quiz3Label.Text = "Quiz 3 :";
            // 
            // Quiz4Label
            // 
            this.Quiz4Label.AutoSize = true;
            this.Quiz4Label.Location = new System.Drawing.Point(897, 489);
            this.Quiz4Label.Name = "Quiz4Label";
            this.Quiz4Label.Size = new System.Drawing.Size(111, 32);
            this.Quiz4Label.TabIndex = 7;
            this.Quiz4Label.Text = "Quiz 4 :";
            this.Quiz4Label.Click += new System.EventHandler(this.label5_Click);
            // 
            // QuizTotalLabel
            // 
            this.QuizTotalLabel.AutoSize = true;
            this.QuizTotalLabel.Location = new System.Drawing.Point(897, 541);
            this.QuizTotalLabel.Name = "QuizTotalLabel";
            this.QuizTotalLabel.Size = new System.Drawing.Size(271, 32);
            this.QuizTotalLabel.TabIndex = 8;
            this.QuizTotalLabel.Text = "Quiz Total (Best 3)  :";
            // 
            // MidLabel
            // 
            this.MidLabel.AutoSize = true;
            this.MidLabel.Location = new System.Drawing.Point(897, 595);
            this.MidLabel.Name = "MidLabel";
            this.MidLabel.Size = new System.Drawing.Size(75, 32);
            this.MidLabel.TabIndex = 9;
            this.MidLabel.Text = "Mid :";
            // 
            // VivaLabel
            // 
            this.VivaLabel.AutoSize = true;
            this.VivaLabel.Location = new System.Drawing.Point(1352, 316);
            this.VivaLabel.Name = "VivaLabel";
            this.VivaLabel.Size = new System.Drawing.Size(85, 32);
            this.VivaLabel.TabIndex = 10;
            this.VivaLabel.Text = "Viva :";
            // 
            // FinalLabel
            // 
            this.FinalLabel.AutoSize = true;
            this.FinalLabel.Location = new System.Drawing.Point(1352, 268);
            this.FinalLabel.Name = "FinalLabel";
            this.FinalLabel.Size = new System.Drawing.Size(92, 32);
            this.FinalLabel.TabIndex = 11;
            this.FinalLabel.Text = "Final :";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(1352, 367);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(250, 32);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.Text = "Total (Out of 300) :";
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.Location = new System.Drawing.Point(1352, 417);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(175, 32);
            this.PercentageLabel.TabIndex = 13;
            this.PercentageLabel.Text = "Percentage :";
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(1352, 477);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(108, 32);
            this.GradeLabel.TabIndex = 14;
            this.GradeLabel.Text = "Grade :";
            // 
            // DevelopedByLabel
            // 
            this.DevelopedByLabel.AutoSize = true;
            this.DevelopedByLabel.Location = new System.Drawing.Point(1352, 595);
            this.DevelopedByLabel.Name = "DevelopedByLabel";
            this.DevelopedByLabel.Size = new System.Drawing.Size(206, 32);
            this.DevelopedByLabel.TabIndex = 15;
            this.DevelopedByLabel.Text = "Developed By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(887, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 698);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DevelopedByLabel);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.PercentageLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.FinalLabel);
            this.Controls.Add(this.VivaLabel);
            this.Controls.Add(this.MidLabel);
            this.Controls.Add(this.QuizTotalLabel);
            this.Controls.Add(this.Quiz4Label);
            this.Controls.Add(this.Quiz3Label);
            this.Controls.Add(this.Quiz2Label);
            this.Controls.Add(this.Quiz1Label);
            this.Controls.Add(this.AttendanceLabel);
            this.Controls.Add(this.student_listbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchIDTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchIDTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox student_listbox;
        private System.Windows.Forms.Label AttendanceLabel;
        private System.Windows.Forms.Label Quiz1Label;
        private System.Windows.Forms.Label Quiz2Label;
        private System.Windows.Forms.Label Quiz3Label;
        private System.Windows.Forms.Label Quiz4Label;
        private System.Windows.Forms.Label QuizTotalLabel;
        private System.Windows.Forms.Label MidLabel;
        private System.Windows.Forms.Label VivaLabel;
        private System.Windows.Forms.Label FinalLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Label DevelopedByLabel;
        private System.Windows.Forms.Label label1;
    }
}

