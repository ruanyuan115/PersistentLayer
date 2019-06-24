using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("course_name")]
    public class CourseName
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int courseNameID { set; get; }
        [SugarColumn(ColumnName = "course_name")]
        public string courseName { set; get; }

        public CourseName() { }
        public CourseName(int courseNameID, string courseName)
        {
            this.courseNameID = courseNameID;
            this.courseName = courseName;
        }
        public int HashCode()
        {
            return this.courseNameID.GetHashCode();
        }
    }
}
