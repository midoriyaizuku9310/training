using System.Data.SqlClient;
using System.Data;

namespace assignment1.Models
{
    public class Owner
    {
        SqlConnection con;
        SqlCommand cmd;
        public Owner()
        {
            string conStr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=mido;Integrated Security=True;";
            con = new SqlConnection(conStr);
        }
        public List<EventOwner> GetOwner()
        {
            List<EventOwner> list = new List<EventOwner>();

            try
            {
                cmd = new SqlCommand("select name,email,mobileno,address,username,password from Event", con);
                cmd.CommandType = CommandType.Text;

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    EventOwner owner = new EventOwner
                    {
                        name = sdr.GetString(0),
                        email = sdr.GetString(1),
                        mobileNumber = sdr.GetString(2),
                        address = sdr.GetString(3),
                        username = sdr.GetString(4),
                        password = sdr.GetString(5),


                    };

                    list.Add(owner);
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

        
        public void AddOwner(EventOwner owner)
        {
            try
            {
                cmd = new SqlCommand("insert into Event values(@on,@oe,@mobile,@add,@un,@pass)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@on", owner.name);
                cmd.Parameters.AddWithValue("@oe", owner.email);
                cmd.Parameters.AddWithValue("@mobile", owner.mobileNumber);
                cmd.Parameters.AddWithValue("@add", owner.address);
                cmd.Parameters.AddWithValue("@un", owner.username);
                cmd.Parameters.AddWithValue("@pass", owner.password);



                con.Open();

                cmd.ExecuteNonQuery();
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
    }
}
