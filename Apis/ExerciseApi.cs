using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class ExerciseApi
    {
         public static Exercise getByID(int? id)
        {
            return Global.db.Queryable<Exercise>().InSingle(id);
        }
        public static List<Exercise> getAll()
        {
            return Global.db.Queryable<Exercise>().ToList();
        }
        public static int? insert(Exercise exercise)
        {
            return exercise.exerciseId!=null?Global.db.Saveable<Exercise>(exercise).ExecuteCommand(): Global.db.Insertable<Exercise>(exercise).ExecuteCommand();
        }
        public static int? update(Exercise exercise)
        {
            return Global.db.Updateable(exercise).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<Exercise>(id).ExecuteCommand();
        }
        public static List<Exercise> findByChapterIdAndExerciseTypeOrderByExerciseNumber(int? chapterId, int? exerciseType)
        {
            return Global.db.Queryable<Exercise>().Where(it => it.chapterId == chapterId && it.exerciseType == exerciseType).OrderBy(it => it.exerciseNumber, SqlSugar.OrderByType.Asc).ToList();
        }
        public static Exercise findByExerciseId(int? id)
        {
            return Global.db.Queryable<Exercise>().Where(it => it.exerciseId == id).First();
        }
        public static List<Exercise> findByChapterId(int? id)
        {
            return Global.db.Queryable<Exercise>().Where(it => it.chapterId == id).ToList();
        }
    }
}
