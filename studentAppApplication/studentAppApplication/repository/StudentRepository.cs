using studentAppApplication.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentAppApplication.repository
{
    public class StudentRepository 
    {

        public List<StudentModel> FindAll() 
        { 
            List<StudentModel> list = new List<StudentModel>(); 

            list.Add(
                new StudentModel() {
                    Idx = 0,
                    Name = "Name",
                    Math = 90,
                    Eng = 80,
                    Kor = 70
                }
            );

            return list;
        }
    }
}
