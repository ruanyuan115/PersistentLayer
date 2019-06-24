using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("course_info")]
    class CourseInfo
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "course_id")]
        public int courseID { set; get; }
        [SugarColumn(ColumnName = "teacher_id")]
        public int teacherID { set; get; }
        [SugarColumn(ColumnName = "course_name")]
        public String courseName { set; get; }
        [SugarColumn(ColumnName = "course_teacher")]
        public String teacherName { set; get; }
        [SugarColumn(ColumnName = "course_year")]
        public int courseYear { set; get; }
        [SugarColumn(ColumnName = "course_semester")]
        public String courseSemester { set; get; }
        [SugarColumn(ColumnName = "start_time")]
        public DateTime startTime { set; get; }
        [SugarColumn(ColumnName = "end_time")]
        public DateTime endTime { set; get; }
        [SugarColumn(ColumnName = "rate")]
        public float rate { set; get; }
    }
}
