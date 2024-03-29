﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeldiGeliyor
{
    public partial class Form2 : Form
    {
        Order gelenOrd;


        public Form2(Order ord)
        {
            InitializeComponent();
            if (ord!=null)
            this.gelenOrd = ord;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            decimal Total = 0;
            foreach (Product item in gelenOrd.Product)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.ProductName;
                li.SubItems.Add(item.Price.ToString());
                li.SubItems.Add(item.Category.CategoryName);
                listView1.Items.Add(li);
                Total += item.Price;
            }

            lblTotalPrice.Text = Total.ToString();
            lblShipDetail.Text = String.Format("Kargo:{0}\nTelefon:{1}\nOrderName:{2}", gelenOrd.Shipper.ShipperName, gelenOrd.Shipper.Phone, gelenOrd.OrderName);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Product item in gelenOrd.Product)
            {
                item.Stock = item.Stock - 1;
            }

        }
    }
}
