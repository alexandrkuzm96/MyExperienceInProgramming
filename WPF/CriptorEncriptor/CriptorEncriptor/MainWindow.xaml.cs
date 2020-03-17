using System;
using System.Windows;
using System.Windows.Input;

namespace CriptorEncriptor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IButtonClick buttonEvent = new ButtonsEvents();
        private IValidator validator = new Validator();
        private Facade facade = new Facade();
        private string CriptType = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenFileClick(object sender, RoutedEventArgs e)
        {
            SourceText.Text = buttonEvent.OpenFile();
        }
        private void SaveFileClick(object sender, RoutedEventArgs e)
        {
            buttonEvent.SaveFile(ConvertedText.Text);
        }
        private void CriptClick(object sender, RoutedEventArgs e)
        {
            try
            {
                ConvertedText.Text = facade.CriptText(SourceText.Text, keyWord.Text,
                    int.Parse(step.Text), CriptType);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Source.ToLower()+
                    ex.Message.ToString());
            }
        }

        private void EncriptClick(object sender, RoutedEventArgs e)
        {
            ConvertedText.Text= facade.EncriptText(SourceText.Text, keyWord.Text,
               int.Parse(step.Text), CriptType);
        }

        private void CaesarChecked(object sender, RoutedEventArgs e)
        {
            keyWord.IsEnabled = false;
            step.IsEnabled = true;
            CriptType = "Caesar";
        }

        private void VigenerChecked(object sender, RoutedEventArgs e)
        {
            keyWord.IsEnabled = true;
            step.IsEnabled = false;
            CriptType = "Vigener";
        }

        private void Step_KeyDown(object sender, KeyEventArgs e)
        {
            validator.ValidateKey(e);
        }
    }
}
