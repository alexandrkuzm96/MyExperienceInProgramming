using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CriptorEncriptor
{
    class ButtonsEvents : IButtonClick
    {
        private ICripterEncripter cripterEncripter= new CripterEncripter();
        private string text="";


        public async Task<string> OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files(*.txt)|*.txt";
            try
            {
                if (ofd.ShowDialog() == true)
                {                    
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        text =await sr.ReadToEndAsync();
                    }
                }       
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Source + ex.Message);
            }
            return text;
        }

        public async void SaveFile(string message)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt";
            try
            {
                if (sfd.ShowDialog() == true)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName,
                         false, Encoding.Default))
                    {
                        await sw.WriteLineAsync(message);
                    }
                        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Source + ex.Message);
            }
        }
    }
}
