using studentAppApplication.conn;
using studentAppApplication.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentAppApplication.repository
{
    public class StudentRepository 
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;  

        StudentRepository() { 
            sqlConnection = DBConn.getConn();
            sqlCommand.Connection = sqlConnection;
        }

        public List<StudentModel> FindAll() 
        { 
            List<StudentModel> list = new List<StudentModel>(); 

            list.Add(
                new StudentModel() {
                    Idx = 0,
                    Name = "성이름",
                    Math = 90,
                    Eng = 80,
                    Kor = 70
                }
            );

            return list;
        }
    }
}
