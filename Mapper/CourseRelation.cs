using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("course_relation")]
    public class CourseRelation
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int? id { set; get; }
        [SugarColumn(ColumnName = "course_name_id")]
        public int? courseNameID { set; get; }
        [SugarColumn(ColumnName = "pre_course_name_id")]
        public int? preCourseNameID { set; get; }
    }
}
