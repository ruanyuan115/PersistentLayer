using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("chapter_relation")]
    class ChapterRelation
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int id { set; get; }
        [SugarColumn(ColumnName = "chapter_id")]
        public int chapterID { set; get; }
        [SugarColumn(ColumnName = "pre_chapter_id")]
        public int preChapterID { set; get; }
    }
}
