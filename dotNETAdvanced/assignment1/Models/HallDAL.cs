using System.Data.SqlClient;
using System.Data;

namespace assignment1.Models
{
    public class HallDAL:IHallDAL
    {

        SqlConnection con;
        SqlCommand comm;
        public HallDAL()
        {
            string conStr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=mido;Integrated Security=True;";
            con = new SqlConnection(conStr);
        }
        public List<Hall> GetHall(int cost)
        {
            List<Hall> list = new List<Hall>();

            try
            {
                comm = new SqlCommand("select hallname,ownername,costperday,mobile,address from hall where costperday<=@cpd", con);
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@cpd", cost);
                con.Open();

                SqlDataReader sdr = comm.ExecuteReader();

                while (sdr.Read())
                {
                    Hall hall = new Hall
                    {
                        hallName = sdr.GetString(0),
                        ownerName= sdr.GetString(1),
                        costPerDay = sdr.GetInt32(2),
                        mobile = sdr.GetString(3),
                        address = sdr.GetString(4)
                    };

                    list.Add(hall);
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
