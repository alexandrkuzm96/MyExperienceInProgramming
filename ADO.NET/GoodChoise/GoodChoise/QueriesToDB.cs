using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GoodChoise
{
    class QueriesToDB
    {
        private SqlConnection sqlcon;
        private SqlDataAdapter adapter;
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectToDB"].ConnectionString;
        private MainWindow mainWindow;

        public void SelectQuery(ref DataTable productTable) {
            sqlcon = new SqlConnection(connectionString);
            SqlCommand sqlComand = new SqlCommand("Select * From Products", sqlcon);
            adapter = new SqlDataAdapter(sqlComand);
            try {
                sqlcon.Open();
                adapter.Fill(productTable);
            }
            catch(Exception ex) {MessageBox.Show(ex.Message.ToString(),ex.Source.ToString());
            }
            finally {
                if (sqlcon != null) {sqlcon.Close(); }
            }
        }

        public void InsertQuery(Product prod) {
            sqlcon = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand
                ("INSERT INTO Products(ProductName, Category, ProductDescription, Price, ProductImage)" +
                "VALUES(@Name,@Category,@ProdDesc,@Price, @Image)",sqlcon);
            try {
                sqlcon.Open();
                SqlParameter nameParam = new SqlParameter("@Name",prod.Name);                
                SqlParameter categoryParam = new SqlParameter("@Category",prod.Category.ToString());
                SqlParameter descParam = new SqlParameter("@ProdDesc",prod.Description.ToString());
                SqlParameter price = new SqlParameter("@Price", prod.Price);
                SqlParameter Image = new SqlParameter("@Image", prod.Image);
                sqlCommand.Parameters.Add(nameParam);
                sqlCommand.Parameters.Add(categoryParam);
                sqlCommand.Parameters.Add(descParam);
                sqlCommand.Parameters.Add(price);
                sqlCommand.Parameters.Add(Image);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Данные внесены");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString(),ex.Source.ToString());
            }
            finally
            {
                if (sqlcon != null) { sqlcon.Close(); }
            }
        }

        public void UpdateQuery() {
            sqlcon = new SqlConnection();
        }

        public void DeleteQuery(int ProductID) {
            try
            {
                sqlcon = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Products WHERE ProductID=(@ID)", sqlcon);
                SqlParameter prodID = new SqlParameter("@ID", ProductID);
                sqlCommand.Parameters.Add(prodID);
                sqlcon.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Удаление прошло успешно.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString());
            }
            finally
            {
                if (sqlcon != null) { sqlcon.Close(); }
            }

        }
    }
}
