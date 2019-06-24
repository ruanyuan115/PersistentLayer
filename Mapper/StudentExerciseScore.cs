using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("student_exercise_score")]
    class StudentExerciseScore
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int id { set; get; }
        [SugarColumn(ColumnName = "student_id")]
        public int studentId { set; get; }
        [SugarColumn(ColumnName = "exercise_id")]
        public int exerciseId { set; get; }
        [SugarColumn(ColumnName = "student_answer")]
        public string studentAnswer { set; get; }
        [SugarColumn(ColumnName = "exercise_score")]
        public int exerciseScore { set; get; }
        [SugarColumn(ColumnName = "corrected")]
        public int corrected { set; get; }
        public StudentExerciseScore()
        {
        }

        public StudentExerciseScore(int studentId, int exerciseId, string studentAnswer, int exerciseScore)
        {
            this.studentId = studentId;
            this.exerciseId = exerciseId;
            this.studentAnswer = studentAnswer;
            this.exerciseScore = exerciseScore;
        }
    }
}
