using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using System.Linq;
using System;

namespace SpaceInvader.ScoreBoard
{
    public class ScoreBoard_Model : BaseModel, IScoreBoard_Model
    {
        int scoreBoardLimit = 10;

        public List<SocoreBoardData> datas { private set; get; }

        public void StoreScore(SocoreBoardData newData)
        {
            datas.Add(newData);
            datas.OrderBy(x => x.score);
            if (datas.Count > scoreBoardLimit)
                datas.RemoveAt(datas.Count - 1);

            SetDataAsDirty();

            var saveString = JsonUtility.ToJson(new ScoreBoardSaveData(datas));
            PlayerPrefs.SetString(saveString, "scoreBoard_save");
        }

        public void LoadData()
        {
            string loadString = PlayerPrefs.GetString("scoreBoard_save");
            if (string.IsNullOrEmpty(loadString)) return;

            var jsonLoad = JsonUtility.FromJson<ScoreBoardSaveData>(loadString);
            datas = new List<SocoreBoardData>(jsonLoad.scoreBoardData);
        }
    }

    public struct SocoreBoardData
    {
        public string name;
        public int score;

        public bool isNull => string.IsNullOrEmpty(name);

        public SocoreBoardData(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }

    struct ScoreBoardSaveData
    {
        public List<SocoreBoardData> scoreBoardData;

        public ScoreBoardSaveData(List<SocoreBoardData> scoreBoardData)
        {
            this.scoreBoardData = scoreBoardData;
        }
    }
}
