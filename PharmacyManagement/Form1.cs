using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class Form1 : Form
    {
        List<Medicine> meds = new List<Medicine>();
        private int salesbalance = 0;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void AddMedicineOnClick(object sender, EventArgs e)
        {
            Medicine dummy = new Medicine();
            dummy.setmedid(MedicineIDTextbox.Text);
            dummy.setmedname(MedicineNameTextbox.Text);
            dummy.setmedquantity(Convert.ToInt32(MedicineQuantityTextbox.Text));
            dummy.setmedprice(Convert.ToInt32(MedicinePriceTextbox.Text));
            meds.Add(dummy);
            MessageBox.Show("Medicine Added Successfully!");
        }

        private void SellMedicineOnClick(object sender, EventArgs e)
        { 
            for (int i = 0; i < meds.Count; i++)
            {
                if (meds[i].getmedid() == SalesIDTextbox.Text)
                {
                    if (meds[i].getmedquantity() < Convert.ToInt32(SalesQuantityTextbox.Text) || meds[i].getmedquantity() < 0)
                    {
                        MessageBox.Show("Medicine Can Not Be Bought!");
                        return;
                    }
                    else
                    {
                        meds[i].setmedquantity(meds[i].getmedquantity() - Convert.ToInt32(SalesQuantityTextbox.Text));
                        salesbalance = salesbalance + (meds[i].getmedprice() * Convert.ToInt32(SalesQuantityTextbox.Text));
                        MessageBox.Show("Medicine Sold Successfully!");
                    }
                }
            }
        }

        private void ShowStockOnClick(object sender, EventArgs e)
        {
            show_medicine_index.Items.Clear();
            for (int i = 0; i < meds.Count; i++)
            {
                if (meds[i].getmedid() == StockIDTextbox.Text)
                {
                    show_medicine_index.Items.Add(meds[i].getmedname());
                    show_medicine_index.Items.Add(" ");
                    show_medicine_index.Items.Add(meds[i].getmedquantity());
                    break;
                }
            }
        }

        private void ShowBalanceOnClick(object sender, EventArgs e)
        {
            BalanceLabel.Text = "Balance: " + (Convert.ToInt32(InitialAccountBalanceTextbox.Text) + salesbalance);
        }
    }
}
