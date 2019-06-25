using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class CourseNameApi
    {
        public static CourseName getByID(int? id)
        {
            return Global.db.Queryable<CourseName>().InSingle(id);
        }
        public static List<CourseName> getAll()
        {
            return Global.db.Queryable<CourseName>().ToList();
        }
        public static int? insert(CourseName courseName)
        {
            return Global.db.Insertable(courseName).ExecuteCommand();
        }
        public static int? update(CourseName courseName)
        {
            return Global.db.Updateable(courseName).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<CourseName>(id).ExecuteCommand();
        }
        public static CourseName getByCourseName(string courseName)
        {
            return Global.db.Queryable<CourseName>().Where(it => it.courseName == courseName).First();
        }
        public static Boolean existsByCourseName(string courseName)
        {
            return Global.db.Queryable<CourseName>().Where(it => it.courseName == courseName).Count()>0?true:false;
        }
        public static CourseName findByCourseName(string courseName)
        {
            return Global.db.Queryable<CourseName>().Where(it => it.courseName == courseName).First();
        }
        public static CourseName findByCourseNameID(int? courseNameID)
        {
            return Global.db.Queryable<CourseName>().Where(it => it.courseNameID == courseNameID).First();
        }
    }
}
