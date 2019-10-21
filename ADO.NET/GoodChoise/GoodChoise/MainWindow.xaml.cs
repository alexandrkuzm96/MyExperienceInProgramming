using System.Windows;
using System.Configuration;
using System.Collections.Generic;
using System.Data;

namespace GoodChoise
{

    public partial class MainWindow : Window
    {
        private QueriesToDB queries;
        private List<Product> products = new List<Product>();
        private DataTable productTable;
        private string connectionString;
        public MainWindow()
        {
            InitializeComponent();           
        }
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {

        }
        private void ProductTableLoad(object sender, RoutedEventArgs e)
        {
            WriteTable();
        }
        private void ShowListClick(object sender, RoutedEventArgs e)
        {
            WriteTable();
        }
        private void AddProductClick(object semder, RoutedEventArgs e )
        {
            AddNewProduct addNewProducts = new AddNewProduct();
            addNewProducts.Owner = this;
            addNewProducts.Show();
        }
        private void DeleteProductClick(object sender, RoutedEventArgs e)
        {
            DeleteProduct deleteProduct = new DeleteProduct();
            deleteProduct.Show();
        }

        public void WriteTable() {
            productTable = new DataTable();
            queries = new QueriesToDB();
            queries.SelectQuery(ref productTable);
            toyTable.ItemsSource = productTable.DefaultView;
        }
    }
}
