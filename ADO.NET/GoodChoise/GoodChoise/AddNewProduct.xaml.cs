using Microsoft.Win32;
using System;
using System.Configuration;
using System.Security.Policy;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GoodChoise
{
    public partial class AddNewProduct : Window
    {
        private BitmapImage productImage;
        public AddNewProduct()
        {
            InitializeComponent();
        }
        private void InputOnlyNums(object sender, KeyEventArgs e)
        {
        }
        private void SelectImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opeNFileDialog = new OpenFileDialog();
            opeNFileDialog.Filter = "Image fiels(*.jpg)|*.jpg| Png fiels(*.png)|*.png";
            if (opeNFileDialog.ShowDialog() == true)
            {
                ChoiseImage.Content = "";
                string path = opeNFileDialog.FileName;
                productImage = new BitmapImage(new Uri(path,
                    UriKind.RelativeOrAbsolute));
                ProductPicture.Source = productImage;
            }
        }
        private void AddProduct(object sender, RoutedEventArgs e)
        {
            
            Product prod = new Product() {
            Name=ProductName.Text,
            Category=ProductCategory.Text,
            Description=ProductDescription.Text,
            Price=Double.Parse(ProductPrice.Text),
            Image=productImage
            };
            QueriesToDB query = new QueriesToDB();
            query.InsertQuery(prod);
        }

    }
}
