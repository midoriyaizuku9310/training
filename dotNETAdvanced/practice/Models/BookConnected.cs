using System.Data.SqlClient;
using System.Data;

namespace practice.Models
{
    public class BookConnected
    {
        SqlConnection con;
        SqlCommand comm;

        public BookConnected()
        {
            string conStr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=mido;Integrated Security=True;";
            con = new SqlConnection(conStr);
        }

        public List<bookStore> getBooks()
        {
            List<bookStore> list = new List<bookStore>();

            try
            {
                comm = new SqlCommand("select BookName,BookId,AuthorName,PublisherName,Copies,Price from bookStore", con);
                comm.CommandType = CommandType.Text;

                con.Open();

                SqlDataReader sdr = comm.ExecuteReader();
                while (sdr.Read())
                {
                    bookStore book = new bookStore
                    {
                        bname = sdr.GetString(0),
                        bid = sdr.GetInt32(1),
                        bauthor = sdr.GetString(2),
                        pname = sdr.GetString(3),
                        copies = sdr.GetInt32(4),
                        price = sdr.GetInt32(5)

                    };
                    list.Add(book);
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

        public void addBooks(bookStore book)
        {
           
                comm = new SqlCommand("insert into bookStore values(@bname,@bid,@bauthor,@pname,@copies,@price)",con);
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@bname", book.bname);
                comm.Parameters.AddWithValue("@bid", book.bid);
                comm.Parameters.AddWithValue("@bauthor", book.bauthor);
                comm.Parameters.AddWithValue("@pname", book.pname);
                comm.Parameters.AddWithValue("@copies", book.copies);
                comm.Parameters.AddWithValue("@price", book.price);

            con.Open();
            comm.ExecuteNonQuery();
            con.Close();

           
        }

        public bookStore GetBookById(int bid)
        {
            try
            {
                
                comm = new SqlCommand("select BookName, BookId, AuthorName, PublisherName, Copies, Price from bookStore where BookId=@bid", con);
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@bid", bid);

                con.Open();
                SqlDataReader sdr = comm.ExecuteReader();

                if (sdr.Read())
                {
                    bookStore emp = new bookStore
                    {
                        bname = sdr.GetString(0),
                        bid = sdr.GetInt32(1),
                        bauthor = sdr.GetString(2),
                        pname = sdr.GetString(3),
                        copies = sdr.GetInt32(4),
                        price = sdr.GetInt32(5)
                    };
                    con.Close();
                    return emp;
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

        public void UpdateBook(bookStore book)
        {
            try
            {

                comm = new SqlCommand("update bookStore set BookName=@bname,AuthorName=@bauthor,PublisherName=@pname,Copies=@copies,Price=@price where BookId=@bid", con);
                comm.CommandType = CommandType.Text;

                //specify the values for the UPDATE parameters
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@bname", book.bname);
                comm.Parameters.AddWithValue("@bid", book.bid);
                comm.Parameters.AddWithValue("@bauthor", book.bauthor);
                comm.Parameters.AddWithValue("@pname", book.pname);
                comm.Parameters.AddWithValue("@copies", book.copies);
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
                //close the connection
                con.Close();
            }
        }
    }
}
