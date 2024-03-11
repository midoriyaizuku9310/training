using System.Data;
using System.Data.SqlClient;

namespace practice.Models
{
    public class BookDisconnected
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;

        public BookDisconnected()
        {
            string conStr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=mido;Integrated Security=True;";
            con = new SqlConnection(conStr);

            da = new SqlDataAdapter("select * from bookStore", con);

            ds = new DataSet();
            da.Fill(ds, "bookStore");

        }

        public List<bookStore> getBooks()
        {


            List<bookStore> list = new List<bookStore>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                bookStore bs = new bookStore
                {
                    bname = (string)row[0],
                    bid = (int)row[1],
                    bauthor = (string)row[2],
                    pname = (string)row[3],
                    copies = (int)row[4],
                    price = (int)row[5]
                };
                list.Add(bs);
            }
            return list;
        }

        public void addBooks(bookStore book)
        {
            DataRow row = ds.Tables[0].NewRow();
            row[0] = book.bname;
            row[1] = book.bid;
            row[2] = book.bauthor;
            row[3] = book.pname;
            row[4] = book.copies;
            row[5] = book.price;
            ds.Tables[0].Rows.Add(row);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "bookStore");
        }
    
}
}
