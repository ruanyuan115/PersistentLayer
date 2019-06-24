using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("takes")]
    public class Takes
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int id { set; get; }
        [SugarColumn(ColumnName = "student_id")]
        public int studentID { set; get; }
        [SugarColumn(ColumnName = "course_class_id")]
        public int courseClassID { set; get; }
        [SugarColumn(ColumnName = "current_progress")]
        public int currentProgress { set; get; }
        [SugarColumn(ColumnName = "comment")]
        public string comment { set; get; }
        [SugarColumn(ColumnName = "rate")]
        public int rate { set; get; }
    }
}
