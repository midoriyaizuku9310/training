using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace dotNETAdvanced
{
    internal class StudentDisconnected
    {

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public StudentDisconnected()
        {
            string conStr = "Data Source=(localdb)\\ProjectModels;Initial Catalog=mido;Integrated Security=True;";
            con = new SqlConnection(conStr);

            da = new SqlDataAdapter("select * from tblStudent", con);

            ds = new DataSet();
            da.Fill(ds, "tblStudent");

        }
        public List<Student> getStudent()
        {
            List<Student> list = new List<Student>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Student stu = new Student
                {
                    sid = (int)row[0],
                    sname = row[1].ToString(),
                    age = (int)row[2],
                    tid = (int)row[3]
                };

                list.Add(stu);
            }
            return list;
        }

        public void addStudent(Student stu)
        {
            DataRow row = ds.Tables[0].NewRow();
            row[0] = stu.sid;
            row[1] = stu.sname;
            row[2] = stu.age;
            row[3] = stu.tid;
            ds.Tables[0].Rows.Add(row);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "tblStudent");
        }
        public void deleteStudent(int sid)
        {
            DataRow[] rows = ds.Tables[0].Select("id=" + sid);
            if (rows.Length > 0)
            {
                foreach (DataRow row in rows)
                {
                    row.Delete();
                }
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "tblStudent");
            }
            else
            {
                throw new Exception("Record not found");
            }
        }
        public void updateStudent(Student stu)
        {
            DataRow[] rows = ds.Tables[0].Select("StudentName="+stu.sname);
            if (rows.Length > 0)
            {
                foreach (DataRow row in rows)
                {
                    row[0] = stu.sid;
                    row[2] = stu.age;
                    row[3] = stu.tid;
                }
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "tblStudent");
            }
            else
            {
                throw new Exception("Record not found");
            }
        }




    }
}
