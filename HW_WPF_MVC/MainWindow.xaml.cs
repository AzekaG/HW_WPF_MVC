using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HW_WPF_MVC.Controller;
namespace HW_WPF_MVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller.Controller controller;
        public MainWindow()
        {

            InitializeComponent();
            controller = new Controller.Controller();
        }
        private void txtListReAdd(object sender, EventArgs e)
        {
            int count = 0;
            txtList.Items.Clear();
            foreach (var el in controller.GetAllPersons())
            {
                txtList.Items.Add((++count).ToString() + " : " + el);
            }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtAge.Text != "" && txtName.Text != "")
            {
                controller.AddPerson(txtName.Text, int.Parse(txtAge.Text));
            }
            else MessageBox.Show("Введите данные!");
            txtAge.Text = string.Empty;
            txtName.Text = string.Empty;
            txtListReAdd(sender, e);
            txtNameSearch.Text = "";

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            txtList.Items.Clear();
            if (txtNameSearch.Text != "")
            {
                foreach (var el in controller.Search(txtNameSearch.Text))
                {
                    txtList.Items.Add((++count).ToString() + " : " + el);
                }
                if (txtList.Items.Count == 0)
                {
                    txtList.Items.Add("По запросу ничего не найдено");
                }
            }
            else MessageBox.Show("Введите параметр поиска!");
            txtNameSearch.Text = "";

        }



        private void txtNameSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            txtNameSearch.Text = string.Empty;
        }




        private void btnUpdate_Click_1(object sender, RoutedEventArgs e)
        {

            
            this.Close();
        }
    }
}
