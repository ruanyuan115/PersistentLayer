-using System;
using System.Collections.Generic;
using System.Text;
using PersistentLayer.Mapper;

namespace PersistentLayer.Apis
{
    class StudentScoreRateApi
    {
        public static List<StudentScoreRate> getStudentScoreRate(List<Dictionary<string,int>> keyMaps)
        {
            List<Tuple<int,int>>tempList= new List<Tuple<int, int>>();
            foreach (var i in keyMaps)
                tempList.Add(new Tuple<int, int>(i["chapterID"], i["studentID"]));
            return Global.db.Queryable<StudentChapter>().In(it => new Tuple<int?,int?>(it.chapterID, it.studentID),tempList).Select(f=>new StudentScoreRate() {
                studentID=f.studentID,
                totalScore_1=f.totalScore_1,
                totalScore_2=f.totalScore_2
            }).ToList();
        }
    }
}
