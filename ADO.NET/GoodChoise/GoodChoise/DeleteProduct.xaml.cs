using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace GoodChoise
{
    /// <summary>
    /// Логика взаимодействия для DeleteProduct.xaml
    /// </summary>
    public partial class DeleteProduct : Window
    { 
        public DeleteProduct()
        {
            InitializeComponent();
        }
        private void DeleteProductClick(object sender, RoutedEventArgs e)
        {
            QueriesToDB queries = new QueriesToDB();
            queries.DeleteQuery(int.Parse(ProductID.Text));
        }
    }
}
