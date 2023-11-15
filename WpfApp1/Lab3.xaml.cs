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
    /// Interaction logic for Lab3.xaml
    /// </summary>
    public partial class Lab3 : Window
    {
        public Lab3()
        {
            InitializeComponent();
        }

        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var n = Convert.ToInt32(N.Text);
            var a = new Building[n * 2];

            for (int i = 0; i < a.Length; i += 2)
            {
                a[i] = new Office { Name = $"Office Building {i / 2 + 1}", NumberOfFloors = i + 10 };
                a[i + 1] = new Factory { Name = $"Factory Building {i / 2 + 1}", NumberOfWorkshops = i + 1000 };
            }

            double maxS = 0.0;
            listBox.Items.Clear();

            for (int i = 0; i < a.Length; i++)
            {
                listBox.Items.Add($"Building: {a[i].Name}\nType: {a[i].GetType().Name}\nFoundation Height: {a[i].CalculateFoundationHeight()}\n");

                if (a[i].CalculateFoundationHeight() > maxS)
                    maxS = a[i].CalculateFoundationHeight();
            }

           // max.Content = maxS.ToString();
        }
    }
}
