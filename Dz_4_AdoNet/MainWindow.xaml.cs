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

namespace Dz_4_AdoNet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Buyer> buyers;
        List<Order> orders;
        List<Seller> sellers;
        public MainWindow()
        {
            InitializeComponent();

            using (SellingModel context = new SellingModel())
            {
                buyers = context.Buyers.ToList();
                orders = context.Orders.ToList();
                sellers = context.Sellers.ToList();
            }
            tableComboBox.Items.Add("buyers");
            tableComboBox.Items.Add("orders");
            tableComboBox.Items.Add("sellers");
            //tableGrid.ItemsSource = buyers;
        }

        private void TableComboBoxDropDownClosed(object sender, EventArgs e)
        {
            if (tableComboBox.SelectedIndex == 0)
            {
                tableGrid.ItemsSource = null;
                tableGrid.ItemsSource = buyers;
            }
            else if (tableComboBox.SelectedIndex == 1)
            {
                tableGrid.ItemsSource = null;
                tableGrid.ItemsSource = orders;
            }
            else if (tableComboBox.SelectedIndex == 2)
            {
                tableGrid.ItemsSource = null;
                tableGrid.ItemsSource = sellers;
            }
        }
    }
}
