//Jason Collier 214008258
//George Smith 214014959
//Louis van der Westhuizen 214009246

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Manage_Employees : Form
    {
        public Manage_Employees()
        {
            InitializeComponent();
        }
        
        Employee[] empArray = new Employee[10];
        int arrCounter = 0;
        int lastEntry = 0;

        private void Display(Employee[] empArray)
        {
            lstEmp.Items.Clear();
            Array.Sort(empArray);
            Array.Reverse(empArray);

            for (int y = 0; y < empArray.Length; y++)
            {
                if (empArray[y] == null)
                {
                    lastEntry = y;
                    break;
                }

            }

            for (int k = 0; k < lastEntry; k++)
            {
                lstEmp.Items.Add(empArray[k].ToString());
            }


            this.Text = "Manage Employees - " + arrCounter.ToString();
        }

        private void Manage_Employees_Load(object sender, EventArgs e)
        {    
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(txtName.Text == "" || txtSurname.Text == "")
                MessageBox.Show("Please enter all details");
            else
            {
                if (arrCounter < 10) 
                {
                    if (rbtnFull.Checked)
                    {
                        if (txtSalary.Text == "")
                        {
                            MessageBox.Show("Please enter all details");
                        }
                        else
                        {
                            try
                            {
                                empArray[arrCounter] = new FullTime(txtName.Text, txtSurname.Text, Convert.ToDecimal(txtSalary.Text));
                                arrCounter++;
                            }
                            catch(Exception exc)
                            {
                                MessageBox.Show(exc.Message);
                            }
                        }
                    }
                    else if (rbtnPart.Checked)
                    {
                        if (txtHours.Text == "" || txtRate.Text == "")
                        {
                            MessageBox.Show("Please enter all details");
                        }
                        else
                        {
                            try
                            {
                                empArray[arrCounter] = new PartTime(txtName.Text, txtSurname.Text, Convert.ToDecimal(txtHours.Text), Convert.ToDecimal(txtRate.Text));
                                arrCounter++;
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.Message);
                            }
                        }
                    }
                }

                if (arrCounter == 10)
                {
                    grbType.Enabled = false;
                    grbDetails.Enabled = false;
                    grbFull.Enabled = false;
                    grbPart.Enabled = false;
                    btnAdd.Enabled = false;
                    lstEmp.Enabled = false;
                }

                txtName.Clear();
                txtSurname.Clear();
                txtSalary.Clear();
                txtHours.Clear();
                txtRate.Clear();

                txtName.Focus();

                Display(empArray);
            }
        }

        private void rbtnFull_CheckedChanged(object sender, EventArgs e)
        {
            grbPart.Enabled = false;
            grbFull.Enabled = true;
        }

        private void rbtnPart_CheckedChanged(object sender, EventArgs e)
        {
            grbFull.Enabled = false;
            grbPart.Enabled = true;
        }
    }
}
