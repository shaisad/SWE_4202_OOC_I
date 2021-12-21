using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomRent
{
    public partial class Form1 : Form
    {
        List<SingleRoom> singlerooms = new List<SingleRoom>();
        List<DoubleRoom> doublerooms = new List<DoubleRoom>();


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SingleRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SingleRoomType.SelectedIndex==0)
            {
                SingleRoomAC.CheckState = CheckState.Unchecked;
                SingleRoomGamingSetup.CheckState = CheckState.Unchecked;

            }
            else if (SingleRoomType.SelectedIndex == 1)
            {
                SingleRoomAC.CheckState = CheckState.Checked;
                SingleRoomGamingSetup.CheckState = CheckState.Unchecked;

            }
            else if (SingleRoomType.SelectedIndex == 2)
            {
                SingleRoomAC.CheckState = CheckState.Unchecked;
                SingleRoomGamingSetup.CheckState = CheckState.Checked;
            }
            else if (SingleRoomType.SelectedIndex == 3)
            {
                SingleRoomAC.CheckState = CheckState.Checked;
                SingleRoomGamingSetup.CheckState = CheckState.Checked;

            }
            SingleRoomAC.Enabled = false;
            SingleRoomGamingSetup.Enabled = false;
        }

        private void AddSingleRoomOnClick(object sender, EventArgs e)
        {
            SingleRoom newroom = new SingleRoom();
            newroom.setrname(SingleRoomType.Text);
            bool choice = false;
            if (NumberOfSingleRooms.Text == "")
            {
                MessageBox.Show("Kindly type the number of rooms");
            }
            else if (SingleRoomType.Text == "")
            {
                MessageBox.Show("Kindly choose a room type or click on the checkboxes");
            }
            else
            {
                choice = true;
            }

            if (choice)
            {
                if (SingleRoomType.Text == "")
                {
                    if (SingleRoomAC.CheckState == CheckState.Unchecked && SingleRoomGamingSetup.CheckState == CheckState.Unchecked)
                    {
                        SingleRoomType.SelectedIndex = 0;
                    }
                    else if (SingleRoomAC.CheckState == CheckState.Checked && SingleRoomGamingSetup.CheckState == CheckState.Unchecked)
                    {
                        SingleRoomType.SelectedIndex = 1;
                    }
                    else if (SingleRoomAC.CheckState == CheckState.Checked && SingleRoomGamingSetup.CheckState == CheckState.Checked)
                    {
                        SingleRoomType.SelectedIndex = 2;
                    }
                    else if (SingleRoomAC.CheckState == CheckState.Unchecked && SingleRoomGamingSetup.CheckState == CheckState.Checked)
                    {
                        SingleRoomType.SelectedIndex = 3;
                    }

                    SingleRoomAC.Enabled = false;
                    SingleRoomGamingSetup.Enabled = false;
                }
                else
                {
                    SingleRoomAC.Enabled = false;
                    SingleRoomGamingSetup.Enabled = false;
                }

                string compareroom = SingleRoomType.Text;
                bool compare = false;
                for (int i = 0; i < singlerooms.Count; i++)
                {
                    if (compareroom == singlerooms[i].getrname())
                    {
                        compare = true;
                        singlerooms[i].setrquantity(Convert.ToInt32(NumberOfSingleRooms.Text) + singlerooms[i].getrquantity());
                        newroom = singlerooms[i];
                        break;
                    }
                }
                if (compare == false)
                {
                    newroom.setrname(compareroom);
                    newroom.setrtv(true);
                    newroom.setrbed(1);
                    newroom.setrquantity(Convert.ToInt32(NumberOfSingleRooms.Text));
                    newroom.setrac(SingleRoomAC.Checked);
                    newroom.setsgamingsetup(SingleRoomGamingSetup.Checked);
                    singlerooms.Add(newroom);
                }
                int cost = newroom.calculatecost();

                MessageBox.Show("There are " + NumberOfSingleRooms.Text + " " + SingleRoomType.Text + "(s) which cost $" + Convert.ToString(cost) + " per day.");
                SingleRoomType.Text = null;
                NumberOfSingleRooms.Text = null;
                SingleRoomAC.CheckState = CheckState.Unchecked;
                SingleRoomGamingSetup.CheckState = CheckState.Unchecked;
                SingleRoomAC.Enabled = true;
                SingleRoomGamingSetup.Enabled = true;

            }
        }

        private void AddDoubleRoomOnClick(object sender, EventArgs e)
        {
            DoubleRoom newroom = new DoubleRoom();
            newroom.setrname(DoubleRoomType.Text);
            bool choice = false;
            if (NumberOfDoubleRooms.Text == "")
            {
                MessageBox.Show("Kindly type the number of rooms");
            }
            else if (DoubleRoomType.Text == "")
            {
                MessageBox.Show("Kindly choose a room type or click on the checkboxes");
            }
            else
            {
                choice = true;
            }
            if (choice)
            {
                if (DoubleRoomType.Text == "")
                {
                    if (DoubleRoomAC.CheckState == CheckState.Unchecked && DoubleRoomTV.CheckState == CheckState.Unchecked && DoubleRoomCBreakfast.CheckState == CheckState.Unchecked)
                    {
                        DoubleRoomType.SelectedIndex = 0;
                    }
                    else if (DoubleRoomAC.CheckState == CheckState.Checked && DoubleRoomTV.CheckState == CheckState.Unchecked && DoubleRoomCBreakfast.CheckState == CheckState.Unchecked)
                    {
                        DoubleRoomType.SelectedIndex = 1;
                    }
                    else if (DoubleRoomAC.CheckState == CheckState.Unchecked && DoubleRoomTV.CheckState == CheckState.Checked && DoubleRoomCBreakfast.CheckState == CheckState.Unchecked)
                    {
                        DoubleRoomType.SelectedIndex = 2;
                    }
                    else if (DoubleRoomAC.CheckState == CheckState.Unchecked && DoubleRoomTV.CheckState == CheckState.Unchecked && DoubleRoomCBreakfast.CheckState == CheckState.Checked)
                    {
                        DoubleRoomType.SelectedIndex = 3;
                    }
                    else if (DoubleRoomAC.CheckState == CheckState.Checked && DoubleRoomTV.CheckState == CheckState.Checked && DoubleRoomCBreakfast.CheckState == CheckState.Unchecked)
                    {
                        DoubleRoomType.SelectedIndex = 4;
                    }
                    else if (DoubleRoomAC.CheckState == CheckState.Checked && DoubleRoomTV.CheckState == CheckState.Unchecked && DoubleRoomCBreakfast.CheckState == CheckState.Checked)
                    {
                        DoubleRoomType.SelectedIndex = 5;
                    }
                    else if (DoubleRoomAC.CheckState == CheckState.Checked && DoubleRoomTV.CheckState == CheckState.Checked && DoubleRoomCBreakfast.CheckState == CheckState.Checked)
                    {
                        DoubleRoomType.SelectedIndex = 6;
                    }
                    else if (DoubleRoomAC.CheckState == CheckState.Unchecked && DoubleRoomTV.CheckState == CheckState.Checked && DoubleRoomCBreakfast.CheckState == CheckState.Checked)
                    {
                        DoubleRoomType.SelectedIndex = 7;
                    }
                }
                DoubleRoomAC.Enabled = false;
                DoubleRoomTV.Enabled = false;
                DoubleRoomCBreakfast.Enabled = false;
                string compareroom = DoubleRoomType.Text;
                bool compare = false;
                for (int i = 0; i < doublerooms.Count; i++)
                {
                    if (compareroom == doublerooms[i].getrname())
                    {
                        compare = true;
                        doublerooms[i].setrquantity(Convert.ToInt32(NumberOfDoubleRooms.Text) + doublerooms[i].getrquantity());
                        newroom = doublerooms[i];
                        break;
                    }
                }
                if (compare == false)
                {
                    newroom.setrname(compareroom);
                    newroom.setrtv(true);
                    newroom.setdtv(DoubleRoomTV.Checked);
                    newroom.setrbed(2);
                    newroom.setrac(DoubleRoomAC.Checked);
                    newroom.setdcbreakfast(DoubleRoomCBreakfast.Checked);
                    newroom.setrquantity(Convert.ToInt32(NumberOfDoubleRooms.Text));
                    doublerooms.Add(newroom);
                }
                int cost = newroom.calculatecost();

                MessageBox.Show("There are " + DoubleRoomType.Text + " " + NumberOfDoubleRooms.Text + " rooms which cost $" + Convert.ToString(cost) + " per day.");
                DoubleRoomType.Text = "";
                NumberOfDoubleRooms.Text = "";
                DoubleRoomAC.Enabled = true;
                DoubleRoomTV.Enabled = true;
                DoubleRoomCBreakfast.Enabled = true;



            }
        }

        private void DoubleRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DoubleRoomType.SelectedIndex == 0)
            {
                DoubleRoomAC.CheckState = CheckState.Unchecked;
                DoubleRoomTV.CheckState = CheckState.Unchecked;
                DoubleRoomCBreakfast.CheckState = CheckState.Unchecked;
            }
            else if (DoubleRoomType.SelectedIndex == 1)
            {
                DoubleRoomAC.CheckState = CheckState.Checked;
                DoubleRoomCBreakfast.CheckState = CheckState.Unchecked;
                DoubleRoomTV.CheckState = CheckState.Unchecked;


            }
            else if (DoubleRoomType.SelectedIndex == 2)
            {
                DoubleRoomAC.CheckState = CheckState.Unchecked;
                DoubleRoomTV.CheckState = CheckState.Checked;
                DoubleRoomCBreakfast.CheckState = CheckState.Unchecked;

            }
            else if (DoubleRoomType.SelectedIndex == 3)
            {
                DoubleRoomAC.CheckState = CheckState.Unchecked;
                DoubleRoomTV.CheckState = CheckState.Unchecked;
                DoubleRoomCBreakfast.CheckState = CheckState.Checked;

            }
            else if (DoubleRoomType.SelectedIndex == 4)
            {
                DoubleRoomAC.CheckState = CheckState.Checked;
                DoubleRoomTV.CheckState = CheckState.Checked;
                DoubleRoomCBreakfast.CheckState = CheckState.Unchecked;
            }
            else if (DoubleRoomType.SelectedIndex == 5)
            {
                DoubleRoomAC.CheckState = CheckState.Checked;
                DoubleRoomTV.CheckState = CheckState.Unchecked;
                DoubleRoomCBreakfast.CheckState = CheckState.Checked;

            }
            else if (DoubleRoomType.SelectedIndex == 6)
            {
                DoubleRoomAC.CheckState = CheckState.Unchecked;
                DoubleRoomTV.CheckState = CheckState.Checked;
                DoubleRoomCBreakfast.CheckState = CheckState.Checked;


            }
            else if (DoubleRoomType.SelectedIndex == 7)
            {

                DoubleRoomAC.CheckState = CheckState.Checked;
                DoubleRoomTV.CheckState = CheckState.Checked;
                DoubleRoomCBreakfast.CheckState = CheckState.Checked;

            }
            DoubleRoomAC.Enabled = false;
            DoubleRoomTV.Enabled = false;
            DoubleRoomCBreakfast.Enabled = false;

        }

        private void RentOnClick(object sender, EventArgs e)
        {

            string search = PickedRoom.Text;

            for (int i = 0; i < doublerooms.Count; i++)
            {

                

                if (search == doublerooms[i].getrname())
                {
                    if (doublerooms[i].getrquantity() > 0)
                    {
                        doublerooms[i].setrquantity(doublerooms[i].getrquantity() - Convert.ToInt32(NumberOfRooms.Text));
                        MessageBox.Show("Room rented successfully");
                    }
                    else
                    {
                        MessageBox.Show("Room can not be rented");
                    }
                    break;
                }
            }

            for (int i = 0; i < singlerooms.Count; i++)
            {
                
                if (search == singlerooms[i].getrname())
                {
                    if (singlerooms[i].getrquantity() > 0)
                    {
                        singlerooms[i].setrquantity(singlerooms[i].getrquantity() - Convert.ToInt32(NumberOfRooms.Text));
                        MessageBox.Show("Room rented successfully");
                    }
                    else
                    {
                        MessageBox.Show("Room cannot be rented");
                    }
                    break;
                }
            }
        }

        private void ShowRoomDetailsOnClick(object sender, EventArgs e)
        {
            Room_Index.Items.Clear();
            string search = AllRooms.Text;
            Room_Index.Items.Add("Name \t\t\t\t Quantity \t\t Cost");
            bool found = false;
            for (int i = 0; i < singlerooms.Count; i++)
            {
                if (search == singlerooms[i].getrname())
                {
                    Room_Index.Items.Add(singlerooms[i].getrname() + "\t" + singlerooms[i].getrquantity() + "\t\t$" + singlerooms[i].calculatecost());
                    found = true;
                    break;
                }
            }

            for (int i = 0; i < doublerooms.Count; i++)
            {
                if (search == doublerooms[i].getrname())
                {
                    Room_Index.Items.Add(doublerooms[i].getrname() + "\t" + doublerooms[i].getrquantity() + "\t\t$" + doublerooms[i].calculatecost());
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                Room_Index.Items.Add(search + "\t N\\A \t\tN\\A");
            }
        }

        private void SingleRoomGamingSetup_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    
}
