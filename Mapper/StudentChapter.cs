using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("student_chapter")]
    class StudentChapter
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int id { set; get; }
        [SugarColumn(ColumnName = "student_id")]
        public int studentID { set; get; }
        [SugarColumn(ColumnName = "chapter_id")]
        public int chapterID { set; get; }
        [SugarColumn(ColumnName = "scored_1")]
        public int scored_1 { set; get; }
        [SugarColumn(ColumnName = "scored_2")]
        public int scored_2 { set; get; }
        [SugarColumn(ColumnName = "total_score_1")]
        public int totalScore_1 { set; get; }
        [SugarColumn(ColumnName = "total_score_2")]
        public int totalScore_2 { set; get; }
        [SugarColumn(ColumnName = "comment")]
        public string comment { set; get; }
        [SugarColumn(ColumnName = "rate")]
        public int rate { set; get; }
    }
}
