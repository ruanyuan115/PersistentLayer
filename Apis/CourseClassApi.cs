using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class CourseClassApi
    {
        public static CourseClass getByID(int? id)
        {
            return Global.db.Queryable<CourseClass>().InSingle(id);
        }
        public static List<CourseClass> getAll()
        {
            return Global.db.Queryable<CourseClass>().ToList();
        }
        public static int? insert(CourseClass courseClass)
        {
            return Global.db.Insertable(courseClass).ExecuteCommand();
        }
        public static int? update(CourseClass courseClass)
        {
            return Global.db.Updateable(courseClass).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<CourseClass>(id).ExecuteCommand();
        }
        public static CourseClass findByClassCode(string classCode)
        {
            return Global.db.Queryable<CourseClass>().Where(it => it.classCode == classCode).First();
        }
        public static List<CourseClass> findByCourseID(int? courseID)
        {
            return Global.db.Queryable<CourseClass>().Where(it => it.courseID == courseID).ToList();
        }
        public static CourseClass findByCourseIDAndClassNum(int? courseID, int? classNum)
        {
            return Global.db.Queryable<CourseClass>().Where(it => it.courseID == courseID && it.classNum == classNum).First();
        }
        
    }
}
