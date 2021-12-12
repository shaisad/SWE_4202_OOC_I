using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental_Dependencies;
namespace CarRental
{
    public partial class Form1 : Form
    {
        List<User>users = new List<User>();
        List<Car>cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void save_user_on_click(object sender, EventArgs e)
        {
            User dummy=new User();
            dummy.setuserid(UserIDTextbox.Text);
            dummy.setusername(UserNameTextbox.Text);
            dummy.setuseraddress(UserAddressTextbox.Text);
            dummy.setuserdestination(UserDestinationTextbox.Text);
            users.Add(dummy);
            MessageBox.Show("User Saved Successfully");
        }

        private void save_car_on_click(object sender, EventArgs e)
        {
            Car dummy = new Car();
            dummy.setcarname(CarNameTextbox.Text);
            dummy.setcarmodel(CarModelTextbox.Text);
            dummy.setcarquantity(Convert.ToInt32(CarQuantityTextbox.Text));
            cars.Add(dummy);
            MessageBox.Show("Car Saved Successfully");
        }

        private void show_user_history_on_click(object sender, EventArgs e)
        {
            show_user_history_lstbx.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].getuserid() == UserIDTextbox.Text)
                {
                    show_user_history_lstbx.Items.Add(users[i].getusername());
                    show_user_history_lstbx.Items.Add(" ");
                    show_user_history_lstbx.Items.Add(users[i].getuseraddress());
                    show_user_history_lstbx.Items.Add(" ");
                    show_user_history_lstbx.Items.Add(users[i].getuserdestination());
                    show_user_history_lstbx.Items.Add(" ");
                    show_user_history_lstbx.Items.Add(users[i].getrentedcarname());
                    break;
                }

            }
            
        }

        private void rent_on_click(object sender, EventArgs e)
        {
            for (int i = 0;i< users.Count;i++)
            {
                if(users[i].getuserid()==UserIDTextbox.Text)
                {
                    users[i].setrentedcarname(RentCarNameTextbox.Text);
                    break;
                }
            }
            for(int i=0;i< cars.Count;i++)
            {
                if (cars[i].getcarname() == RentCarNameTextbox.Text)
                {
                    cars[i].setcarquantity(cars[i].getcarquantity()-1);
                    break;
                }
            }
            MessageBox.Show("Rented Successfully");

        }

        private void show_car_history_on_click(object sender, EventArgs e)
        {
            show_car_history_lst_bx.Items.Clear();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].getcarname() == CarNameTextbox.Text)
                {
                    show_car_history_lst_bx.Items.Add(cars[i].getcarmodel());
                    show_car_history_lst_bx.Items.Add(" ");
                    show_car_history_lst_bx.Items.Add(cars[i].getcarquantity());
                   

                    break;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
