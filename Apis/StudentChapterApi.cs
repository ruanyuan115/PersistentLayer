using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    class StudentChapterApi
    {
        public static StudentChapter getByID(int? id)
        {
            return Global.db.Queryable<StudentChapter>().InSingle(id);
        }
        public static List<StudentChapter> getAll()
        {
            return Global.db.Queryable<StudentChapter>().ToList();
        }
        public static int? insert(StudentChapter studentChapter)
        {
            return Global.db.Insertable(studentChapter).ExecuteCommand();
        }
        public static int? update(StudentChapter studentChapter)
        {
            return Global.db.Updateable(studentChapter).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<StudentChapter>(id).ExecuteCommand();
        }
        public static StudentChapter findByChapterIDAndStudentID(int? chapterID, int? studentID)
        {
            return (StudentChapter)Global.db.Queryable<StudentChapter>().Where(it => it.chapterID == chapterID && it.studentID == studentID);
        }
        public static Boolean existsByChapterIDAndStudentID(int? chapterID, int? studentID)
        {
            return Global.db.Queryable<StudentChapter>().Where(it => it.chapterID == chapterID && it.studentID == studentID).Count() > 0 ? true : false;
        }
        public static List<StudentChapter> findByChapterIDBetweenAndStudentIDOrderByChapterIDDesc(int? least, int? most, int? studentId)
        {
            return Global.db.Queryable<StudentChapter>().Where(it => it.chapterID >= least && it.chapterID <= most && it.studentID == studentId).OrderBy(it => it.chapterID, SqlSugar.OrderByType.Desc).ToList();
        }
        public static List<StudentChapter> findByChapterID(int? chapterID)
        {
            return Global.db.Queryable<StudentChapter>().Where(it => it.chapterID == chapterID).ToList();
        }
        public static int? countByChapterIDAndRate(int? chapterID, int? rate)
        {
            return Global.db.Queryable<StudentChapter>().Where(it => it.chapterID == chapterID && it.rate == rate).Count();
        }
        public static string getNLPRateByChapterIDAndStudentID(int? chapterID, int? studentID)
        {
            return Global.db.Queryable<StudentChapter>().Where(it => it.chapterID == chapterID && it.studentID == studentID).Select(f => f.nlpRate).ToString();
        }
        public static int? setNLPRateByChapterIDAndStudentID(string nlpRate, int?chapterID, int? studentID)
        {
            return Global.db.Updateable<StudentChapter>().UpdateColumns(it => new StudentChapter() { nlpRate = nlpRate }).Where(it => it.chapterID == chapterID && it.studentID == studentID).ExecuteCommand();
        }
    }
}
