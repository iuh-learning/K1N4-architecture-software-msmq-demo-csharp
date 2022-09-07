using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Object
{
    [Serializable]
    public class Student
    {
        public long studentId { get; set; }
        public string fullName { get; set; }
        public DateTime DOB { get; set; }

        public Student()
        {
            this.studentId = 0;
            this.fullName = "no-name";
            this.DOB = new DateTime();
        }

        public Student(long id, string fname, DateTime dob)
        {
            this.studentId = id; this.fullName = fname; this.DOB = dob;
        }

        public override String ToString()
        {
            return this.fullName + "\t" + this.DOB;
        }
    }
}
