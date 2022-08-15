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

        public List<SocoreData> datas { private set; get; } = new List<SocoreData>();

        public void StoreScore(SocoreData newData)
        {
            datas.Add(newData);
            datas.OrderBy(x => x.score);
            if (datas.Count > scoreBoardLimit)
                datas.RemoveAt(datas.Count - 1);

            SetDataAsDirty();

            Debug.Log("Adding Score : " + newData.name + "|" + newData.score);

            var saveString = JsonUtility.ToJson(new ScoreBoardSaveData(datas));
            PlayerPrefs.SetString(saveString, "scoreBoard_save");
        }

        public void LoadData()
        {
            string loadString = PlayerPrefs.GetString("scoreBoard_save");
            if (string.IsNullOrEmpty(loadString)) return;

            var jsonLoad = JsonUtility.FromJson<ScoreBoardSaveData>(loadString);
            datas = new List<SocoreData>(jsonLoad.scoreBoardData);
        }
    }

    public struct SocoreData
    {
        public string name;
        public int score;

        public bool isNull => string.IsNullOrEmpty(name);

        public SocoreData(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }

    struct ScoreBoardSaveData
    {
        public List<SocoreData> scoreBoardData;

        public ScoreBoardSaveData(List<SocoreData> scoreBoardData)
        {
            this.scoreBoardData = scoreBoardData;
        }
    }
}
