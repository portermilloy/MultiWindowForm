using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowForm
{
    public partial class NewCustomerForm : Form
    {
        private MainForm _mainForm;
        private int CustomerCount = 0;
        private bool IsEditing;
        private int CurrentSelectionId;
        public NewCustomerForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            CustomerCount++;
            IsEditing = false;
            CurrentSelectionId = -1;
        }

        public void ToggleEdit(bool newState)
        {
            IsEditing = newState;
        }

        private void CreateCustomer()
        {
            // validation
            if (CheckValidity(txtName))
            {
                MessageBox.Show("Name is empty, please provide a Name.");
                return;
            }
            if (CheckValidity(txtEmail))
            {
                MessageBox.Show("Email is empty, please provide an Email.");
                return;
            }
            if (CheckValidity(txtPhoneNumber))
            {
                MessageBox.Show("Phone Number is empty, please provide a Phone Number.");
                return;
            }


            // create a custoemr and load it with data from the form
            Customer customer = new Customer
            {
                CustomerId = CustomerCount,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text
            };


            // send that data to the AddCustomer function on the parent form
            _mainForm.AddCustomer(customer);
            CustomerCount++;
        }

        

        private bool CheckValidity(Control control)
        {
            return control.Text == "";
        }

        private void EditCustomer()
        {
            // validators here, exit early if invalid
            if (CheckValidity(txtName))
            {
                MessageBox.Show("Name is empty, please provide a Name.");
                return;
            }
            if (CheckValidity(txtEmail))
            {
                MessageBox.Show("Email is empty, please provide an Email.");
                return;
            }
            if (CheckValidity(txtPhoneNumber))
            {
                MessageBox.Show("Phone Number is empty, please provide a Phone Number.");
                return;
            }

            // tell the main form what our customer looks like
            _mainForm.EditCustomer(CurrentSelectionId, new Customer
            {
                CustomerId = CurrentSelectionId,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text
            });

            CurrentSelectionId = -1;
            ToggleEdit(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                

                // edit the item in place
                EditCustomer();
            }
            else
            {
                // creat a new customer
                CreateCustomer();
            }

            ClearForm();

            Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
        }

        public void LoadCustomer(Customer customer)
        {
            CurrentSelectionId = customer.CustomerId;
            txtName.Text = customer.Name;
            txtEmail.Text = customer.Email;
            txtPhoneNumber.Text = customer.PhoneNumber;
        }
    }
}
