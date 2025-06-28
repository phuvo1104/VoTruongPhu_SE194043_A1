using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessObject;
using Services;
namespace VoTruongPhuWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly EmployeesService employeesService = new EmployeesService();
        private readonly CustomerService customerService = new CustomerService();

        public Window1()
        {
            InitializeComponent();
        }

        // Employee login
        private void BtnEmployeeLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmpEmail.Text;
            string password = txtEmpPassword.Password;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            var employee = employeesService.FindByUsernameAndPassword(email, password);
            if (employee != null)
            {
                MessageBox.Show($"Welcome {employee.Name}!");
                new Admin().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        // Customer login
        private void BtnCustomerLogin_Click(object sender, RoutedEventArgs e)
        {
            string phone = txtCustomerPhone.Text;
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter your phone number.");
                return;
            }

            var customer = customerService.GetAllCustomers()
                .FirstOrDefault(c => c.Phone == phone);

            if (customer != null)
            {
                MessageBox.Show($"Welcome {customer.ContactName}!");
                new Customer(customer).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Phone number not found.");
            }
        }
    }
}
