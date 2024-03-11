using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace dotNETAdvanced
{
    internal class StudentConnected
    {
        SqlConnection con;
        SqlCommand cmd;
       

        public StudentConnected()
        {
            string conStr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=mido;Integrated Security=True;";
            con = new SqlConnection(conStr);
        }

        public List<Student> getStudent()
        {
            List<Student> students = new List<Student>();

            try
            {
                cmd = new SqlCommand("select Id,StudentName,Age,ClassTeacherId from tblStudent", con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Student stu = new Student
                    {
                        sid = sdr.GetInt32(0),
                        sname = sdr.GetString(1),
                        age = sdr.GetInt32(2),
                        tid = sdr.GetInt32(3)

                    };
                    students.Add(stu);
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
            return students;
        }

        public int commStu(string sname, int age)
        {
            int count = 0;
            try
            {
                cmd = new SqlCommand("select Id,StudentName,Age,ClassTeacherId from tblStudent where StudentName=@sname and Age=@age", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sname",sname );
                cmd.Parameters.AddWithValue("@age",age );
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
               //count = (int) cmd.ExecuteScalar();
               while(sdr.Read())
                {
                    count++;
                }
                return count;
                
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


        public void addStudent(Student stu )
        {
            try
            {
                cmd = new SqlCommand("insert into tblStudent values(@si,@sn,@sa,@ti)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@si", stu.sid);
                cmd.Parameters.AddWithValue("@sn", stu.sname);
                cmd.Parameters.AddWithValue("@sa", stu.age);
                cmd.Parameters.AddWithValue("@ti", stu.tid);
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

        public int updateStudent(Student stu)
        {
            try
            {
                //configure command for UPDATE
                cmd = new SqlCommand("update tblStudent set StudentName=@sn,Age=@sa ,ClassTeacherId=@ti where Id=@sid", con);
                cmd.CommandType = CommandType.Text;

                //specify the values for the UPDATE parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sid", stu.sid);
                cmd.Parameters.AddWithValue("@sn", stu.sname);
                cmd.Parameters.AddWithValue("@sa", stu.age);
                cmd.Parameters.AddWithValue("@ti", stu.tid);

                //open connection
                con.Open();

                //execute the command
                cmd.ExecuteNonQuery();
               object changes= cmd.ExecuteNonQuery();
                return Convert.ToInt32(changes);



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

        public void deleteStudent(int stu)
        {
            try
            {
                //configure the command for DELETE BY ID
                cmd = new SqlCommand("delete from tblStudent where Id=@sid", con);
                cmd.CommandType = CommandType.Text;

                //specify parameter value
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sid", stu);

                //open connection and execute the command
                con.Open();
                cmd.ExecuteNonQuery();
              

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

        public int totalAge()
        {
            try
            {
                cmd = new SqlCommand("select sum(Age) from tblStudent", con);
                cmd.CommandType = CommandType.Text;

                con.Open();

                object result = cmd.ExecuteScalar();

                return Convert.ToInt32(result);

            }
            catch(Exception ex)
            {
                throw ex;
            }


        }

        public void deleteSP(string sname, int age)
        {
            int n = 0;
            try
            {
                cmd = new SqlCommand("delcomm",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sname", sname);
                cmd.Parameters.AddWithValue("@age",age);
                con.Open();
               // cmd.ExecuteNonQuery();
                n  = cmd.ExecuteNonQuery();
                Console.WriteLine($"no of rows deleted:{n}");
               
            }
            catch(Exception ex)
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
