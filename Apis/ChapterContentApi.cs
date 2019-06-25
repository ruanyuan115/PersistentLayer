using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class ChapterContentApi
    {
        public static ChapterNode getByID(int? id)
        {
            return Global.db.Queryable<ChapterNode>().InSingle(id);
        }
        public static List<ChapterNode>getAll()
        {
            return Global.db.Queryable<ChapterNode>().ToList();
        }
        public static int? insert(ChapterNode chapterNode)
        {
            return chapterNode.id!=null?Global.db.Saveable<ChapterNode>(chapterNode).ExecuteCommand(): Global.db.Insertable(chapterNode).ExecuteCommand();
        }
        public static int? update(ChapterNode chapterNode)
        {
            return Global.db.Updateable(chapterNode).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<ChapterNode>(id).ExecuteCommand();
        }
        public static List<ChapterNode> findByCourseID(int? courseID)
        {
            return Global.db.Queryable<ChapterNode>().Where(it => it.courseID == courseID).ToList();
        }
        public static List<ChapterNode> findByCourseIDAndParentID(int? courseID, int? parentID)
        {
            return Global.db.Queryable<ChapterNode>().Where(it => it.courseID == courseID && it.parentID == parentID).ToList();
        }
        public static ChapterNode findByCourseIDAndParentIDAndSiblingID(int? courseID,int? parentID,int? siblingID)
        {
            return Global.db.Queryable<ChapterNode>().Where(it => it.courseID==courseID&&it.parentID == parentID && it.siblingID == siblingID).First();
        }
    }
}
