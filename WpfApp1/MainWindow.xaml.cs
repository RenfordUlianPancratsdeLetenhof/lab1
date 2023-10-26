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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ans_polyminal_with_x_button_Click(object sender, RoutedEventArgs e)
        {
            Polyminal polyminal;

            double a, b, c, d, x;

            try
            {
                a = Convert.ToDouble(a_textbox_1.Text);
                b = Convert.ToDouble(b_textbox_1.Text);
                c = Convert.ToDouble(c_textbox_1.Text);
                d = Convert.ToDouble(d_textbox_1.Text);
                x = Convert.ToDouble(x_textbox_.Text);

                polyminal = new Polyminal(a, b, c, d);

                ans_polyminal_with_x.Content = polyminal.evaluate(x);
                polyminal_look_for_x.Content = polyminal.output_polyminal();

            }

            catch
            {
                MessageBox.Show("Помилка");
                return;
            }
        }

        private void answer_random_diapaz_Click(object sender, RoutedEventArgs e)
        {
            Polyminal first_polyminal, second_polyminal, answer_polyminal;

            int min, max;
            double x;

            try
            {
                min = Convert.ToInt32(min_diapzon.Text);
                max = Convert.ToInt32(max_diapzon.Text);
                x = Convert.ToDouble(texbox_for_x_diapaz.Text);
                first_polyminal = new Polyminal(min, max);
                second_polyminal = new Polyminal(min, max);
                answer_polyminal = first_polyminal.adding(second_polyminal);

                first_polyminal_label.Content = first_polyminal.output_polyminal();
                second_polyminal_label.Content = second_polyminal.output_polyminal();
                answer_polyminal_label.Content = answer_polyminal.output_polyminal();

                if (x != 0)
                {
                    answer_for_x_diapaz.Content = answer_polyminal.evaluate(x);
                } 
        
            }
            catch
            {
                MessageBox.Show("Помилка");
                return;
            }
        }

        private void fix_diapaz_calculate_Click(object sender, RoutedEventArgs e)
        {
            Polyminal first_polyminal, second_polyminal, answer_polyminal;
            double x;

            try
            {
                first_polyminal = new Polyminal();
                second_polyminal = new Polyminal(); 
                x = Convert.ToDouble(third_x.Text);
                answer_polyminal = first_polyminal.substract(second_polyminal);
               


                first_polyminal_fix_diapz.Content = first_polyminal.output_polyminal();
                second_polyminal_fix_diapz.Content = second_polyminal.output_polyminal();
                answer_polyminal_fix_diapz.Content = answer_polyminal.output_polyminal();
                
                if (x != 0)
                {
                    ans_with_x_polyminal_fix_diapz.Content = answer_polyminal.evaluate(x);
                }
                
            }

            catch
            {
                MessageBox.Show("Помилка");
                return;
            }
        }
    }
}
