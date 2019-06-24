using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("course_notice")]
    class CourseNotice
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int id { set; get; }
        [SugarColumn(ColumnName = "course_id")]
        public int courseID { set; get; }
        [SugarColumn(ColumnName = "course_notice")]
        public string courseNotice { set; get; }

    }
}
