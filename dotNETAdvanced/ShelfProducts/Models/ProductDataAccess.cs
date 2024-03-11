using System.Data.SqlClient;
using System.Data;

namespace ShelfProducts.Models
{
    public class ProductDataAccess
    {
        SqlConnection con;
        SqlCommand comm;
        public ProductDataAccess()
        {
            string conStr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=mido;Integrated Security=True;";
            con = new SqlConnection(conStr);
        }
        public List<Product> GetProducts()
        {
            List<Product> list = new List<Product>();

            try
            {
                comm = new SqlCommand("select ProductName,ProductCode,BrandName,StockLeft,Price,ExpiryDate from ShelfProducts", con);
                comm.CommandType = CommandType.Text;

                con.Open();

                SqlDataReader sdr = comm.ExecuteReader();

                while (sdr.Read())
                {
                    Product pro = new Product
                    {
                        Pname = sdr.GetString(0),
                        Pcode = sdr.GetInt32(1),
                        Bname = sdr.GetString(2),
                        Sleft = sdr.GetInt32(3),
                        price = sdr.GetDecimal(4),
                        dt = sdr.GetDateTime(5),
                    };

                    list.Add(pro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return list;
        }
    }
}
