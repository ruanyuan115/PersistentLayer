using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class CourseInfoApi
    {
        public static CourseInfo getByID(int? id)
        {
            return Global.db.Queryable<CourseInfo>().InSingle(id);
        }
        public static List<CourseInfo> getAll()
        {
            return Global.db.Queryable<CourseInfo>().ToList();
        }
        public static int? insert(CourseInfo courseInfo)
        {
            return Global.db.Insertable(courseInfo).ExecuteCommand();
        }
        public static int? update(CourseInfo courseInfo)
        {
            return Global.db.Updateable(courseInfo).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<CourseInfo>(id).ExecuteCommand();
        }
        public static CourseInfo findByCourseID(int? courseID)
        {
            return (CourseInfo)Global.db.Queryable<CourseInfo>().Where(it => it.courseID == courseID);
        }
        public static List<CourseInfo> findByTeacherID(int? teacherID)
        {
            return Global.db.Queryable<CourseInfo>().Where(it => it.teacherID == teacherID).ToList();
        }
        public static List<CourseInfo> findByCourseName(string nameID)
        {
            return Global.db.Queryable<CourseInfo>().Where(it => it.courseName == nameID).ToList();
        }
        public static List<CourseInfo> findByCourseYear(int? year)
        {
            return Global.db.Queryable<CourseInfo>().Where(it => it.courseYear == year).ToList();
        }
        public static List<CourseInfo> findByCourseNameAndTeacherID(string courseNameID, int? teacherID)
        {
            return Global.db.Queryable<CourseInfo>().Where(it => it.courseName == courseNameID && it.teacherID == teacherID).ToList();
        }
        public static List<CourseInfo> findByCourseYearAndCourseSemester(int? year, string semester)
        {
            return Global.db.Queryable<CourseInfo>().Where(it => it.courseYear == year && it.courseSemester == semester).ToList();
        }
        public static List<CourseInfo> findByTeacherIDAndCourseYearAndCourseSemester(int? teacherId, int? year, string semester)
        {
            return Global.db.Queryable<CourseInfo>().Where(it => it.teacherID == teacherId && it.courseYear == year && it.courseSemester == semester).ToList();
        }
    }
}
