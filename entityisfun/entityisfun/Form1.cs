using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entityisfun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayCountries();
            DisplayTitles();
        }

        private void DisplayCustomers()
        {
            using (var dc = new NorthwindEntities())
            {
                var customers = from c in dc.Customers
                    select new
                    {
                        CustomerId = c.CustomerID,
                        Name = c.ContactName,
                        Title = c.ContactTitle,
                        Country = c.Country
                    };

               

                if (!string.IsNullOrWhiteSpace(tbCustomerName.Text))
                    customers = customers.Where(c => c.Name.Contains(tbCustomerName.Text));

                if (cbContactTitles.SelectedIndex != 0)
                    customers = customers.Where(c => c.Title == cbContactTitles.SelectedItem);

                if (cbCountries.SelectedIndex != 0)
                    customers = customers.Where(c => c.Country == cbCountries.SelectedItem);

                dgvCustomers.DataSource = customers.ToList();
            }
        }

        private void DisplayCountries()
        {
            using (var dc = new NorthwindEntities())
            {
                var countries = (from c in dc.Customers
                                 orderby c.Country
                                 select c.Country).Distinct();


                cbCountries.Items.AddRange(countries.ToArray());
                cbCountries.SelectedIndex = 0;
            }
        }
        private void DisplayTitles()
        {
            using (var dc = new NorthwindEntities())
            {
                var titles = (from c in dc.Customers
                              orderby c.ContactTitle
                              select c.ContactTitle).Distinct();
                cbContactTitles.Items.AddRange(titles.ToArray());
                cbContactTitles.SelectedIndex = 0;
            }
        }
        private void DisplayCategories()
        {
            using (var dc = new NorthwindEntities())
            {
                var categories = (from c in dc.Categories
                    orderby c.CategoryName
                    select c.CategoryName);
                cbCategories.Items.AddRange(categories.ToArray());
                cbCategories.SelectedIndex = 0;
            } 

        }

        private void cbFilter_CheckedChanged(object sender, EventArgs e)
        {
            gbFiltering.Visible = cbFilter.Checked;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCustomers();
            DisplayCategories();
        }
    }
}
