﻿using avtorisation;
using System;
using System.Windows;

namespace RegistrationApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string Login = txtLogin.Text;
            string Password = txtPassword.Password;


            if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password))
            {
                 if ((txtLogin.Text == "TheMostSuccsesfullProgrammerInTheWorld") && (txtPassword.Password == "123Cool"))
                 {
                     //MessageBox.Show("Registration successful!");
                     Window1 window1 = new Window1();
                     window1.Show();
                     Close();
                 }

                 if ((txtLogin.Text == "TheQueenOfClean") && (txtPassword.Password == "BestCleaner001"))
                 {
                     //MessageBox.Show("Registration successful!");
                    Window1 window1 = new Window1();
                    window1.Show();
                    Close();

                }
                 else
                 {
                     MessageBox.Show("Please enter both username and password.");
                 }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
            string name = txtLogin.Text != string.Empty ? txtLogin.Text:string.Empty;


        }
    }
}
