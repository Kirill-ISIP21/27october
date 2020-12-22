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

namespace _27october
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            double sum;
            if (txtSumma.Text == "")
            {
                sum = 0;
            }
            else
            {
                sum = Convert.ToDouble(txtSumma.Text);
            }

            if (sum > 2000)
            {
                sum *= 0.97;
                tblItog.Text = "Ваша скидка: 3% \nИтого: " + sum.ToString() + " рублей";
            }
            else
            {
                tblItog.Text = "Итого: " + sum.ToString() + " рублей";
            }
        }
    }
}
