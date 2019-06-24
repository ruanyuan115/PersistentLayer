using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    class ChapterContentApi
    {
        public ChapterNode getByID(int id)
        {
            return Global.db.Queryable<ChapterNode>().InSingle(id);
        }
        public List<ChapterNode>getAll()
        {
            return Global.db.Queryable<ChapterNode>().ToList();
        }
        public int insert(ChapterNode chapterNode)
        {
            return Global.db.Insertable(chapterNode).ExecuteCommand();
        }
        public int update(ChapterNode chapterNode)
        {
            return Global.db.Updateable(chapterNode).ExecuteCommand();
        }
        public int delete(int id)
        {
            return Global.db.Deleteable<ChapterNode>(id).ExecuteCommand();
        }

    }
}
