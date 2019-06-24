using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("course_class")]
    public class CourseClass
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int? id { set; get; }
        [SugarColumn(ColumnName = "course_id")]
        public int? courseID { set; get; }
        [SugarColumn(ColumnName = "class_num")]
        public int? classNum { set; get; }
        [SugarColumn(ColumnName = "class_code")]
        public string classCode { set; get; }
        [SugarColumn(ColumnName = "current_exercise")]
        public int? currentExerciseChapter { set; get; }
    }
}
