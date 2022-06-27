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


namespace NDScalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        private List contr;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            contr = new List();
            
        }

        /// <summary>
        /// загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
            List controller = new List();
            cb.ItemsSource = controller.qwerty;
            pricevalue.Text = "1";
            NDSvalue.Text = "10";
            

        }
            
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int price = Convert.ToInt32(pricevalue.Text);
                int NDS = Convert.ToInt32(NDSvalue.Text);
                int price2 = price * NDS / 100;
                int price3 = price + price2;

                int pricev = Convert.ToInt32(pricevalue.Text);
                int NDSv = Convert.ToInt32(NDSvalue.Text);
                int pricev1 = pricev * NDSv * 20 / 120;
                int pricev2 = pricev + pricev1;

                string v = cb.SelectedItem.ToString();

                if (v == "Начислить") 
                {
                    eshkeregrr.Content = $" НДС добавлен:{price2},{price3} Сумма с НДС.";
                }
                else if (v == "Выделить")
                {
                    eshkeregrr.Content = $" НДС выделен:{pricev1},{pricev2} Сумма без НДС.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }

        
    }
}
