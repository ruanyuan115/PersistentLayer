using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class ChapterRelationApi
    {
        public static ChapterRelation getByID(int? id)
        {
            return Global.db.Queryable<ChapterRelation>().InSingle(id);
        }
        public static List<ChapterRelation> getAll()
        {
            return Global.db.Queryable<ChapterRelation>().ToList();
        }
        public static int? insert(ChapterRelation chapterRelation)
        {
            return Global.db.Insertable(chapterRelation).ExecuteCommand();
        }
        public static int? update(ChapterRelation chapterRelation)
        {
            return Global.db.Updateable(chapterRelation).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<ChapterRelation>(id).ExecuteCommand();
        }
        public static ChapterRelation findByChapterIDAndPreChapterID(int? chapterID, int? preChapterID)
        {
            var temp=Global.db.Queryable<ChapterRelation>().Where(it => it.chapterID == chapterID && it.preChapterID == preChapterID).First();
            return temp;
        }
        public static List<ChapterRelation> findByChapterID(Int32? chapterID)
        {
            return Global.db.Queryable<ChapterRelation>().Where(it => it.chapterID == chapterID).ToList();
        }
        public static List<ChapterRelation> findByPreChapterID(Int32? preChapterID)
        {
            return Global.db.Queryable<ChapterRelation>().Where(it => it.preChapterID == preChapterID).ToList();
        }
    }
}
