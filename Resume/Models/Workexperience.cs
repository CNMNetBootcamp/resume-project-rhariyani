using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Workexperience
    {
        public int ID { get; set; }
        public string ExperieceDescription { get; set; }
       // public int Work { get; set; }

        public int JobID { get; set; }
        public Job Job { get; set; }
    }
}
