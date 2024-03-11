using System.Data.SqlClient;
using System.Data;

namespace RazorProjectCRUD.DataAccess
{
    public class EmployeeDataAccess
    {
        SqlConnection con;
        SqlCommand comm;
        public EmployeeDataAccess()
        {
            string conStr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=mido;Integrated Security=True;";
            con = new SqlConnection(conStr);
        }
        public List<Employee> GetEmps()
        {
            List<Employee> list = new List<Employee>();

            try
            {
                comm = new SqlCommand("select eid,ename,salary,deptid from tbl_employees", con);
                comm.CommandType = CommandType.Text;

                con.Open();

                SqlDataReader sdr = comm.ExecuteReader();

                while (sdr.Read())
                {
                    Employee emp = new Employee
                    {
                        Ecode = sdr.GetInt32(0),
                        Ename = sdr.GetString(1),
                        salary = sdr.GetInt32(2),
                        deptid = sdr.GetInt32(3)
                    };

                    list.Add(emp);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { 

            con.Close();
        }

            return list;
        }
        public Employee GetEmpById(int id)
        {
            try
            {
                //configure command for SELECT BY ID
                comm = new SqlCommand("select eid,ename,salary,deptid from tbl_employees where eid=@ec", con);
                comm.CommandType = CommandType.Text;

                //specify parameter value
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@ec", id);

                //open connection and execute the command
                con.Open();
                SqlDataReader sdr = comm.ExecuteReader();

                //read the record
                if (sdr.Read())
                {
                    Employee emp = new Employee
                    {
                        Ecode = sdr.GetInt32(0),
                        Ename = sdr.GetString(1),
                        salary = sdr.GetInt32(2),
                        deptid = sdr.GetInt32(3)
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

        public void DeleteEmployee(int ecode)
        {
            try
            {
                //configure the command for DELETE BY ID
                comm = new SqlCommand("delete from tbl_employees where eid=@ec", con);
                comm.CommandType = CommandType.Text;

                //specify parameter value
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@ec", ecode);

                //open connection and execute the command
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

        public void AddEmployee(Employee emp)
        {
            try
            {
                //configure command for INSERT
                comm = new SqlCommand("insert into tbl_employees values(@ec,@en,@sal,@did)", con);
                comm.CommandType = CommandType.Text;

                //specify the values for the INSERT parameters
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@ec", emp.Ecode);
                comm.Parameters.AddWithValue("@en", emp.Ename);
                comm.Parameters.AddWithValue("@sal", emp.salary);
                comm.Parameters.AddWithValue("@did", emp.deptid);

                //open connection
                con.Open();

                //execute the command
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


        public void UpdateEmployee(Employee emp)
        {
            try
            {
                //configure command for UPDATE
                comm = new SqlCommand("update tbl_employees set ename=@en,salary=@sal,deptid=@did where eid=@ec", con);
                comm.CommandType = CommandType.Text;

                //specify the values for the UPDATE parameters
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@ec", emp.Ecode);
                comm.Parameters.AddWithValue("@en", emp.Ename);
                comm.Parameters.AddWithValue("@sal", emp.salary);
                comm.Parameters.AddWithValue("@did", emp.deptid);

                //open connection
                con.Open();

                //execute the command
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
