namespace RoomRent
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
            this.NumberOfSingleRooms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddS = new System.Windows.Forms.Button();
            this.SingleRoomAC = new System.Windows.Forms.CheckBox();
            this.SingleRoomType = new System.Windows.Forms.ComboBox();
            this.SingleRoomGamingSetup = new System.Windows.Forms.CheckBox();
            this.DoubleRoomCBreakfast = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Room_Index = new System.Windows.Forms.ListBox();
            this.PickedRoom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DoubleRoomTV = new System.Windows.Forms.CheckBox();
            this.DoubleRoomType = new System.Windows.Forms.ComboBox();
            this.DoubleRoomAC = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberOfDoubleRooms = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NumberOfRooms = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AllRooms = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NumberOfSingleRooms
            // 
            this.NumberOfSingleRooms.Location = new System.Drawing.Point(155, 124);
            this.NumberOfSingleRooms.Name = "NumberOfSingleRooms";
            this.NumberOfSingleRooms.Size = new System.Drawing.Size(100, 22);
            this.NumberOfSingleRooms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Type";
            // 
            // AddS
            // 
            this.AddS.Location = new System.Drawing.Point(65, 164);
            this.AddS.Name = "AddS";
            this.AddS.Size = new System.Drawing.Size(156, 32);
            this.AddS.TabIndex = 2;
            this.AddS.Text = "Add Single Room";
            this.AddS.UseVisualStyleBackColor = true;
            this.AddS.Click += new System.EventHandler(this.AddSingleRoomOnClick);
            // 
            // SingleRoomAC
            // 
            this.SingleRoomAC.AutoSize = true;
            this.SingleRoomAC.Location = new System.Drawing.Point(65, 67);
            this.SingleRoomAC.Name = "SingleRoomAC";
            this.SingleRoomAC.Size = new System.Drawing.Size(18, 17);
            this.SingleRoomAC.TabIndex = 3;
            this.SingleRoomAC.UseVisualStyleBackColor = true;
            // 
            // SingleRoomType
            // 
            this.SingleRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SingleRoomType.FormattingEnabled = true;
            this.SingleRoomType.Items.AddRange(new object[] {
            "Single Room",
            "Single Room + A/C",
            "Single Room + Gaming Setup",
            "Single Room + A/C + Gaming Setup"});
            this.SingleRoomType.Location = new System.Drawing.Point(122, 27);
            this.SingleRoomType.Name = "SingleRoomType";
            this.SingleRoomType.Size = new System.Drawing.Size(253, 24);
            this.SingleRoomType.TabIndex = 4;
            this.SingleRoomType.SelectedIndexChanged += new System.EventHandler(this.SingleRoomType_SelectedIndexChanged);
            // 
            // SingleRoomGamingSetup
            // 
            this.SingleRoomGamingSetup.AutoSize = true;
            this.SingleRoomGamingSetup.Location = new System.Drawing.Point(137, 96);
            this.SingleRoomGamingSetup.Name = "SingleRoomGamingSetup";
            this.SingleRoomGamingSetup.Size = new System.Drawing.Size(18, 17);
            this.SingleRoomGamingSetup.TabIndex = 5;
            this.SingleRoomGamingSetup.UseVisualStyleBackColor = true;
            this.SingleRoomGamingSetup.CheckedChanged += new System.EventHandler(this.SingleRoomGamingSetup_CheckedChanged);
            // 
            // DoubleRoomCBreakfast
            // 
            this.DoubleRoomCBreakfast.AutoSize = true;
            this.DoubleRoomCBreakfast.Location = new System.Drawing.Point(193, 333);
            this.DoubleRoomCBreakfast.Name = "DoubleRoomCBreakfast";
            this.DoubleRoomCBreakfast.Size = new System.Drawing.Size(18, 17);
            this.DoubleRoomCBreakfast.TabIndex = 6;
            this.DoubleRoomCBreakfast.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "A/C?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gaming Setup?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Number of Rooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Complimentary Breakfast?";
            // 
            // Room_Index
            // 
            this.Room_Index.FormattingEnabled = true;
            this.Room_Index.ItemHeight = 16;
            this.Room_Index.Location = new System.Drawing.Point(472, 286);
            this.Room_Index.Name = "Room_Index";
            this.Room_Index.Size = new System.Drawing.Size(438, 228);
            this.Room_Index.TabIndex = 13;
            // 
            // PickedRoom
            // 
            this.PickedRoom.FormattingEnabled = true;
            this.PickedRoom.Items.AddRange(new object[] {
            "Single Room",
            "Single Room + A/C",
            "Single Room + Gaming Setup",
            "Single Room + A/C + Gaming Setup",
            "Double Room",
            "Double Room + A/C",
            "Double Room + TV",
            "Double Room + Gaming Setup",
            "Double Room + A/C + TV",
            "Double Room + A/C + Breakfast",
            "Double Room + TV + Breakfast",
            "Double Room + A/C + TV + Breakfast"});
            this.PickedRoom.Location = new System.Drawing.Point(472, 30);
            this.PickedRoom.Name = "PickedRoom";
            this.PickedRoom.Size = new System.Drawing.Size(287, 24);
            this.PickedRoom.TabIndex = 14;
            this.PickedRoom.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Number of Rooms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Extra TV?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "A/C?";
            // 
            // DoubleRoomTV
            // 
            this.DoubleRoomTV.AutoSize = true;
            this.DoubleRoomTV.Location = new System.Drawing.Point(96, 297);
            this.DoubleRoomTV.Name = "DoubleRoomTV";
            this.DoubleRoomTV.Size = new System.Drawing.Size(18, 17);
            this.DoubleRoomTV.TabIndex = 20;
            this.DoubleRoomTV.UseVisualStyleBackColor = true;
            // 
            // DoubleRoomType
            // 
            this.DoubleRoomType.FormattingEnabled = true;
            this.DoubleRoomType.Items.AddRange(new object[] {
            "Double Room",
            "Double Room + A/C",
            "Double Room + TV",
            "Double Room + Gaming Setup",
            "Double Room + A/C + TV",
            "Double Room + A/C + Breakfast",
            "Double Room + TV + Breakfast",
            "Double Room + A/C + TV + Breakfast"});
            this.DoubleRoomType.Location = new System.Drawing.Point(122, 229);
            this.DoubleRoomType.Name = "DoubleRoomType";
            this.DoubleRoomType.Size = new System.Drawing.Size(253, 24);
            this.DoubleRoomType.TabIndex = 19;
            this.DoubleRoomType.SelectedIndexChanged += new System.EventHandler(this.DoubleRoomType_SelectedIndexChanged);
            // 
            // DoubleRoomAC
            // 
            this.DoubleRoomAC.AutoSize = true;
            this.DoubleRoomAC.Location = new System.Drawing.Point(65, 269);
            this.DoubleRoomAC.Name = "DoubleRoomAC";
            this.DoubleRoomAC.Size = new System.Drawing.Size(18, 17);
            this.DoubleRoomAC.TabIndex = 18;
            this.DoubleRoomAC.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add Double Room";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddDoubleRoomOnClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Room Type";
            // 
            // NumberOfDoubleRooms
            // 
            this.NumberOfDoubleRooms.Location = new System.Drawing.Point(155, 359);
            this.NumberOfDoubleRooms.Name = "NumberOfDoubleRooms";
            this.NumberOfDoubleRooms.Size = new System.Drawing.Size(100, 22);
            this.NumberOfDoubleRooms.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Number of Rooms";
            // 
            // NumberOfRooms
            // 
            this.NumberOfRooms.Location = new System.Drawing.Point(601, 68);
            this.NumberOfRooms.Name = "NumberOfRooms";
            this.NumberOfRooms.Size = new System.Drawing.Size(100, 22);
            this.NumberOfRooms.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Rent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RentOnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(547, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowRoomDetailsOnClick);
            // 
            // AllRooms
            // 
            this.AllRooms.FormattingEnabled = true;
            this.AllRooms.Items.AddRange(new object[] {
            "Single Room",
            "Single Room + A/C",
            "Single Room + Gaming Setup",
            "Single Room + A/C + Gaming Setup",
            "Double Room",
            "Double Room + A/C",
            "Double Room + TV",
            "Double Room + Gaming Setup",
            "Double Room + A/C + TV",
            "Double Room + A/C + Breakfast",
            "Double Room + TV + Breakfast",
            "Double Room + A/C + TV + Breakfast"});
            this.AllRooms.Location = new System.Drawing.Point(472, 189);
            this.AllRooms.Name = "AllRooms";
            this.AllRooms.Size = new System.Drawing.Size(287, 24);
            this.AllRooms.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 532);
            this.Controls.Add(this.AllRooms);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NumberOfRooms);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DoubleRoomTV);
            this.Controls.Add(this.DoubleRoomType);
            this.Controls.Add(this.DoubleRoomAC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumberOfDoubleRooms);
            this.Controls.Add(this.PickedRoom);
            this.Controls.Add(this.Room_Index);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoubleRoomCBreakfast);
            this.Controls.Add(this.SingleRoomGamingSetup);
            this.Controls.Add(this.SingleRoomType);
            this.Controls.Add(this.SingleRoomAC);
            this.Controls.Add(this.AddS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfSingleRooms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberOfSingleRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddS;
        private System.Windows.Forms.CheckBox SingleRoomAC;
        private System.Windows.Forms.ComboBox SingleRoomType;
        private System.Windows.Forms.CheckBox SingleRoomGamingSetup;
        private System.Windows.Forms.CheckBox DoubleRoomCBreakfast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Room_Index;
        private System.Windows.Forms.ComboBox PickedRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox DoubleRoomTV;
        private System.Windows.Forms.ComboBox DoubleRoomType;
        private System.Windows.Forms.CheckBox DoubleRoomAC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumberOfDoubleRooms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NumberOfRooms;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox AllRooms;
    }
}

