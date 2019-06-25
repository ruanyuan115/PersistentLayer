using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class TakesApi
    {
        public static Takes getByID(int? id)
        {
            return Global.db.Queryable<Takes>().InSingle(id);
        }
        public static List<Takes> getAll()
        {
            return Global.db.Queryable<Takes>().ToList();
        }
        public static int? insert(Takes takes)
        {
            return Global.db.Insertable(takes).ExecuteCommand();
        }
        public static int? update(Takes takes)
        {
            return Global.db.Updateable(takes).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<Takes>(id).ExecuteCommand();
        }
        public static List<Takes> findByStudentID(int? studentID)
        {
            return Global.db.Queryable<Takes>().Where(it => it.studentID == studentID).ToList();
        }
        public static Takes findByStudentIDAndCourseClassID(int? studentID, int? courseClassID)
        {
            return (Takes)Global.db.Queryable<Takes>().Where(it => it.studentID == studentID && it.courseClassID == courseClassID);
        }
        public static List<Takes> findByCourseClassID(int? courseClassID)
        {
            return Global.db.Queryable<Takes>().Where(it => it.courseClassID == courseClassID).ToList();
        }
    }
}
