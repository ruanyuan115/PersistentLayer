using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    class StudentExerciseScoreApi
    {
        public static StudentExerciseScore getByID(int? id)
        {
            return Global.db.Queryable<StudentExerciseScore>().InSingle(id);
        }
        public static List<StudentExerciseScore> getAll()
        {
            return Global.db.Queryable<StudentExerciseScore>().ToList();
        }
        public static int? insert(StudentExerciseScore studentExerciseScore)
        {
            return Global.db.Insertable(studentExerciseScore).ExecuteCommand();
        }
        public static int? update(StudentExerciseScore studentExerciseScore)
        {
            return Global.db.Updateable(studentExerciseScore).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<StudentExerciseScore>(id).ExecuteCommand();
        }
        public static StudentExerciseScore findByExerciseIdAndStudentId(int? exerciseId, int? studentId)
        {
            return (StudentExerciseScore)Global.db.Queryable<StudentExerciseScore>().Where(it => it.exerciseId == exerciseId && it.studentId == studentId);
        }
        public static Boolean existsByExerciseIdAndStudentId(int? exerciseId, int? studentId)
        {
            return Global.db.Queryable<StudentExerciseScore>().Where(it=>it.exerciseId==exerciseId&&it.studentId==studentId).Count()>0?true:false;
        }
    }
}
