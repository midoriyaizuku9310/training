using System.Data.SqlClient;
using System.Data;

namespace EmployeeWebAPI.Models
{
    public interface IBookDataAccess 
    {
        public List<Books> getBooks();
        public Books getBookById(int id);

        public void addBooks(Books book);
        public void update(Books book);
        public void delete(int id);




    }

    public class BookDataAccess : IBookDataAccess
    {
        SqlConnection con;
        SqlCommand comm;

        public BookDataAccess()
        {
            string conStr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=mido;Integrated Security=True;";
            con = new SqlConnection(conStr);
        }

        public List<Books> getBooks()
        {
            List<Books> list = new List<Books>();

            try
            {
                comm = new SqlCommand("select Bid,BName,BPub,price from tblBooks", con);
                comm.CommandType = CommandType.Text;

                con.Open();

                SqlDataReader sdr = comm.ExecuteReader();
                while (sdr.Read())
                {
                    Books book = new Books
                    {
                        Bid = sdr.GetInt32(0),
                        BName = sdr.GetString(1),
                        BPub = sdr.GetString(2),
                        price = sdr.GetInt32(3)

                    };
                    list.Add(book);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return list;
        }
           
        public Books getBookById(int id)
        {
            try
            {
                    comm = new SqlCommand("select Bid,BName,BPub,price from tblBooks where Bid=@bid", con);
                    comm.CommandType = CommandType.Text;

                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@bid", id);

                    con.Open();
                    SqlDataReader sdr = comm.ExecuteReader();

                    if (sdr.Read())
                    {
                        Books book = new Books
                        {
                            Bid = sdr.GetInt32(0),
                            BName = sdr.GetString(1),
                            BPub = sdr.GetString(2),
                            price = sdr.GetInt32(3)
                        };
                        con.Close();
                        return book;
                    }
                    else
                    {
                        throw new Exception("Record not found!");
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
            
        }
   
        public void addBooks(Books book)
        {
            try
            {
                comm = new SqlCommand("insert into tblBooks values(@bid,@bname,@bpub,@price)", con);
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@bid", book.Bid);
                comm.Parameters.AddWithValue("@bname", book.BName);
                comm.Parameters.AddWithValue("@bpub", book.BPub);
                comm.Parameters.AddWithValue("@price", book.price);

                con.Open();

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void update(Books book)
        {
            try
            {
                comm = new SqlCommand("update  tblBooks set BName=@bname,BPub=@bpub,price=@price where Bid=@bid", con);
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@bid", book.Bid);
                comm.Parameters.AddWithValue("@bname", book.BName);
                comm.Parameters.AddWithValue("@bpub", book.BPub);
                comm.Parameters.AddWithValue("@price", book.price);

                con.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }


        public void delete(int id)
        {
            try
            {
                comm = new SqlCommand("delete from tblBooks where Bid=@bid", con);
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@bid", id);

                con.Open();
                comm.ExecuteNonQuery();
            }
            catch(Exception ex) {
                throw ex;
            }
            finally { con.Close(); }
        }
    
    }
}
