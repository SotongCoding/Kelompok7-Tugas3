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
            datas = datas.OrderByDescending(x => x.score).ToList();

            if (datas.Count > scoreBoardLimit)
                datas.RemoveAt(datas.Count - 1);

            SetDataAsDirty();

            Debug.Log("Adding Score : " + newData.name + "|" + newData.score);

            var saveString = JsonUtility.ToJson(new ScoreBoardSaveData(datas));
            Debug.Log("Score Save : " + saveString);
            PlayerPrefs.SetString("scoreBoard_save", saveString);
        }

        public void LoadData()
        {
            string loadString = PlayerPrefs.GetString("scoreBoard_save");
            Debug.Log(loadString);
            if (string.IsNullOrEmpty(loadString)) return;

            var jsonLoad = JsonUtility.FromJson<ScoreBoardSaveData>(loadString);
            Debug.Log(jsonLoad.scoreBoardData);
            datas = new List<SocoreData>(jsonLoad.scoreBoardData);
            datas = datas.OrderByDescending(x => x.score).ToList();
        }
    }

    [System.Serializable]
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

    [System.Serializable]
    struct ScoreBoardSaveData
    {
        public List<SocoreData> scoreBoardData;

        public ScoreBoardSaveData(List<SocoreData> scoreBoardData)
        {
            this.scoreBoardData = new List<SocoreData>(scoreBoardData);
        }
    }
}
