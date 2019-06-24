using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("exercise_choice")]
    class ExerciseChoice
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int id { set; get; }
        [SugarColumn(ColumnName = "exercise_id")]
        public int exerciseId { set; get; }
        [SugarColumn(ColumnName = "exercice_choice_id")]
        public string exerciceChoiceId { set; get; }
        [SugarColumn(ColumnName = "choice")]
        public string choice { set; get; }
        public ExerciseChoice()
        {
        }

        public ExerciseChoice(int exerciseId, string exerciceChoiceId, string choice)
        {
            this.exerciseId = exerciseId;
            this.exerciceChoiceId = exerciceChoiceId;
            this.choice = choice;
        }
    }
}
