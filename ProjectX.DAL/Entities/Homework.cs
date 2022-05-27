using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.DAL.Entities
{
    public class Homework
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
