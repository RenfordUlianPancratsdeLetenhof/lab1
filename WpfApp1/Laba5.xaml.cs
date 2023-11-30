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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Laba5.xaml
    /// </summary>
    public partial class Laba5 : Window
    {
        public Laba5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var tabul = new Tabul();
                double xn = Convert.ToDouble(textBox1.Text);
                double xk = Convert.ToDouble(textBox2.Text);
                double h = Convert.ToDouble(textBox3.Text);

                tabul.GetList(xn, xk, h);

                listBox1.Items.Clear();
                foreach (var point in tabul.Points)
                {
                    listBox1.Items.Add(
                        $"x={Math.Round(point.X, 2)} " +
                        $"y={Math.Round(point.Y, 3)} " +
                        $"Цикл={Math.Round(point.Y_cikl, 3)} " +
                        $"Рекурсія={Math.Round(point.Y_rek, 3)}"
                    );
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
