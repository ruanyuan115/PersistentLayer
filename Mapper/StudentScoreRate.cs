using System;
using System.Collections.Generic;
using System.Text;

namespace PersistentLayer.Mapper
{
    public class StudentScoreRate
    {
        public int? studentID { get; set; }
        public int? totalScore_1 { get; set; }
        public int? totalScore_2{ get; set; }
        public int? rate{ get; set; }
    }
}
