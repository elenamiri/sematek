using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace sematek.Models;

    public class StudentCourse
    {
        public Student Student { get; set; }
        public Master Master { get; set; }
        public course course { get; set; }
        public DateTime CreatedAt { get; set; }
}

