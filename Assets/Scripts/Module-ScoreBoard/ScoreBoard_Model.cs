using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using System.Linq;

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
        }
    }

    public struct SocoreBoardData
    {
        public string name;
        public int score;

        public SocoreBoardData(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}
