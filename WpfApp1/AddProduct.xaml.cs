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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.appFrame.GoBack();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cars editCar = new Cars()
                {
                    Id = AppFrame.cars.Capacity,
                    carNumber = carNumberTextBox.Text.ToString(),
                    type = typeTextBox.Text.ToString(),
                    cost = Int32.Parse(costTextBox.Text),
                    status = statusTextBox.Text.ToString()
                };

                if (editCar.Id != 0 && editCar.carNumber != "" && editCar.type != "" && editCar.cost != 0 && editCar.status != "")
                {
                    AppFrame.cars.Add(editCar);
                    MessageBox.Show("Добавлен новый штраф c Id " + editCar.Id);
                    AppFrame.appFrame.Navigate(new CarPage());
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Не заполнены все поля или заполнены не верно!");
            }
        }
    }
}
