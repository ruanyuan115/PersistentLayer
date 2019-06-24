using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace PersistentLayer.Mapper
{
    [SugarTable("exercise")]
    public class Exercise
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "exercise_id")]
        public int exerciseId { set; get; }

        [SugarColumn(ColumnName = "chapter_Id")]
        public int chapterId { set; get; }
        [SugarColumn(ColumnName = "exercise_type")]
        public int exerciseType { set; get; }
        [SugarColumn(ColumnName = "exercise_number")]
        public int exerciseNumber { set; get; }
        [SugarColumn(ColumnName = "exercise_content")]
        public string exerciseContent { set; get; }
        [SugarColumn(ColumnName = "exercise_answer")]
        public string exerciseAnswer { set; get; }
        [SugarColumn(ColumnName = "exercise_analysis")]
        public string exerciseAnalysis { set; get; }
        [SugarColumn(ColumnName = "exercise_point")]
        public int exercisePoint { set; get; }

        public Exercise()
        {
        }

        public Exercise(int chapterId, int exerciseType, int exerciseNumber, string exerciseContent, string exerciseAnswer, string exerciseAnalysis, int exercisePoint)
        {
            this.chapterId = chapterId;
            this.exerciseType = exerciseType;
            this.exerciseNumber = exerciseNumber;
            this.exerciseContent = exerciseContent;
            this.exerciseAnswer = exerciseAnswer;
            this.exerciseAnalysis = exerciseAnalysis;
            this.exercisePoint = exercisePoint;
        }
    }
}
