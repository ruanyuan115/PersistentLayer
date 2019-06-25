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
            return chapterRelation.id!=null?Global.db.Saveable<ChapterRelation>(chapterRelation).ExecuteCommand(): Global.db.Insertable(chapterRelation).ExecuteCommand();
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
        public static List<ChapterRelation> findByChapterID(int? chapterID)
        {
            return Global.db.Queryable<ChapterRelation>().Where(it => it.chapterID == chapterID).ToList();
        }
        public static List<ChapterRelation> findByPreChapterID(int? preChapterID)
        {
            return Global.db.Queryable<ChapterRelation>().Where(it => it.preChapterID == preChapterID).ToList();
        }
    }
}
