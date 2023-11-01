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
using WpfApp1.Inheritance;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Lab2.xaml
    /// </summary>
    public partial class Lab2 : Window
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Hide();
        }

        private void calculate_weigth_button_Click(object sender, RoutedEventArgs e)
        {



            if (string.IsNullOrWhiteSpace(animal_name_textbox.Text) ||
                string.IsNullOrWhiteSpace(animal_breed_textbox.Text) ||
                string.IsNullOrWhiteSpace(animal_height_textbox.Text) ||
                string.IsNullOrWhiteSpace(animal_k_textbox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля перед продовженням.");
                return;
            }

            try
            {

                string name = animal_name_textbox.Text;
                double height = double.Parse(animal_height_textbox.Text);
                string breed = animal_breed_textbox.Text;
                int k = int.Parse(animal_k_textbox.Text);


                Cat cat = new Cat(name, height, breed, k);
                cat_name_label.Content = cat.Print_name();
                cat_weigth_label.Content = cat.weight_of_animal();

            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка у введенні даних.");
            }

        }
    }
}