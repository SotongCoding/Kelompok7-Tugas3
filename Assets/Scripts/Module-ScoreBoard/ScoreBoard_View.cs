using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.ScoreBoard
{
    public class ScoreBoard_View : ObjectView<IScoreBoard_Model>
    {

        [Header("UI")]
        [SerializeField] GameObject scoreBoardObj;

        [SerializeField] Button showLeaderBoard;
        [SerializeField] UI_ScoreBoard_ScoreObj scorePrefab;
        [SerializeField] Transform scoreObjPlace;

        // public Button testingAddScore;
        // public PowerUps.PowerUps_View powerUpPrefab;


        void RefreshScoreBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                if (_model.datas.Count <= i) return;

                UI_ScoreBoard_ScoreObj currentScoreObj;
                if (scoreObjPlace.childCount <= i)
                    currentScoreObj = Instantiate(scorePrefab, scoreObjPlace);
                else
                {
                    currentScoreObj = scoreObjPlace.GetChild(i).GetComponent<UI_ScoreBoard_ScoreObj>();
                }
                if (_model.datas.Count > i)
                {
                    currentScoreObj.SetScore(_model.datas[i]);
                }
            }
        }

        protected override void InitRenderModel(IScoreBoard_Model model)
        {
            if (scoreBoardObj != null)
                RefreshScoreBoard();
        }
        protected override void UpdateRenderModel(IScoreBoard_Model model)
        {
            if (scoreBoardObj != null)
                RefreshScoreBoard();
        }

    }
}
