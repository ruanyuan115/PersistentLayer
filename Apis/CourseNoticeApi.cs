using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    class CourseNoticeApi
    {
        public static CourseNotice getByID(int? id)
        {
            return Global.db.Queryable<CourseNotice>().InSingle(id);
        }
        public static List<CourseNotice> getAll()
        {
            return Global.db.Queryable<CourseNotice>().ToList();
        }
        public static int? insert(CourseNotice courseNotice)
        {
            return Global.db.Insertable(courseNotice).ExecuteCommand();
        }
        public static int? update(CourseNotice courseNotice)
        {
            return Global.db.Updateable(courseNotice).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<CourseNotice>(id).ExecuteCommand();
        }
        public static CourseNotice findByCourseID(int? courseID)
        {
            return (CourseNotice)Global.db.Queryable<CourseNotice>().Where(it => it.courseID == courseID);
        }
        public static void deleteByCourseID(int? courseID)
        {
            Global.db.Deleteable<CourseNotice>().Where(it => it.courseID == courseID).ExecuteCommand();
        }
    }
}
