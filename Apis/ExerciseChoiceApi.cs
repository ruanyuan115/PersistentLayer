using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    public class ExerciseChoiceApi
    {
        public static ExerciseChoice getByID(int? id)
        {
            return Global.db.Queryable<ExerciseChoice>().InSingle(id);
        }
        public static List<ExerciseChoice> getAll()
        {
            return Global.db.Queryable<ExerciseChoice>().ToList();
        }
        public static int? insert(ExerciseChoice exerciseChoice)
        {
            return exerciseChoice.id!=null?Global.db.Saveable(exerciseChoice).ExecuteCommand(): Global.db.Insertable(exerciseChoice).ExecuteCommand();
        }
        public static int? update(ExerciseChoice exerciseChoice)
        {
            return Global.db.Updateable(exerciseChoice).ExecuteCommand();
        }
        public static int? delete(int? id)
        {
            return Global.db.Deleteable<ExerciseChoice>(id).ExecuteCommand();
        }
        public static List<ExerciseChoice> findByExerciseIdOrderByExerciceChoiceId(int? exerciseId)
        {
            return Global.db.Queryable<ExerciseChoice>().Where(it => it.exerciseId == exerciseId).OrderBy(it => it.exerciseId, SqlSugar.OrderByType.Asc).ToList();
        }
    }
}
