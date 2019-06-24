using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("chapter_content")]
    class ChapterNode
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public Int32 id { set; get; }
        [SugarColumn(ColumnName = "course_id")]
        public int courseID { get; set; }
        [SugarColumn(ColumnName = "content_name")]
        public string contentName { get; set; }
        [SugarColumn(ColumnName = "parent_id")]
        public int parentID { get; set; }
        [SugarColumn(ColumnName = "sibling_id")]
        public int siblingID { get; set; }
        [SugarColumn(ColumnName = "content")]
        public string content { get; set; }
        [SugarColumn(ColumnName = "exercise_title")]
        public string exerciseTitle { get; set; }
        [SugarColumn(ColumnName = "exercise_visible_1")]
        public Boolean exerciseVisible_1 { get; set; }
        [SugarColumn(ColumnName = "exercise_visible_2")]
        public Boolean exerciseVisible_2 { get; set; }
        [SugarColumn(ColumnName = "exercise_deadline_1")]
        public DateTime exerciseDeadline_1 { get; set; }
        [SugarColumn(ColumnName = "exercise_deadline_2")]
        public DateTime exerciseDeadline_2 { get; set; }
        [SugarColumn(ColumnName = "exercise_total_1")]
        public int exerciseTotal_1 { get; set; }
        [SugarColumn(ColumnName = "exercise_total_2")]
        public int exerciseTotal_2 { get; set; }

    }
}
