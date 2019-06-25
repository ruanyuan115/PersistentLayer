using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class CourseRelationApi
    {
        public static CourseRelation getByID(int? id)
        {
            return Global.db.Queryable<CourseRelation>().InSingle(id);
        }
        public static List<CourseRelation> getAll()
        {
            return Global.db.Queryable<CourseRelation>().ToList();
        }
        public static int? insert(CourseRelation courseRelation)
        {
            return Global.db.Insertable(courseRelation).ExecuteCommand();
        }
        public static int? update(CourseRelation courseRelation)
        {
            return Global.db.Updateable(courseRelation).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<CourseRelation>(id).ExecuteCommand();
        }
        public static CourseRelation findByCourseNameIDAndPreCourseNameID(int? courseNameID, int? preCourseNameID)
        {
            return (CourseRelation)Global.db.Queryable<CourseRelation>().Where(it => it.courseNameID == courseNameID && it.preCourseNameID == preCourseNameID);
        }
        public static List<CourseRelation> findByPreCourseNameID(int? preCourseNameID)
        {
            return Global.db.Queryable<CourseRelation>().Where(it => it.preCourseNameID == preCourseNameID).ToList();
        }
        public static List<CourseRelation> findByCourseNameID(int? courseID)
        {
            return Global.db.Queryable<CourseRelation>().Where(it => it.courseNameID == courseID).ToList();
        }
    }
}
