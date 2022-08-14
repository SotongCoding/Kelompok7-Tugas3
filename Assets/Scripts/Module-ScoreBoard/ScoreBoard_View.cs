using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using Agate.MVC.Base;

namespace SpaceInvader.ScoreBoard
{
    public class ScoreBoard_View : ObjectView<IScoreBoard_Model>
    {

        [Header("UI")]
        [SerializeField] GameObject scoreBoardObj;

        [SerializeField] Button showLeaderBoard;
        [SerializeField] UI_ScoreBoard_ScoreObj scorePrefab;
        [SerializeField] Transform scoreObjPlace;


        public void ShowScoreBoard()
        {
            scoreObjPlace.gameObject.SetActive(!scoreObjPlace.gameObject.activeSelf);
        }

        void RefreshScoreBoard()
        {
            for (int i = 0; i < 3; i++)
            {
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

        public void SetButtonCallback()
        {
            showLeaderBoard.onClick.RemoveAllListeners();
            showLeaderBoard.onClick.AddListener(ShowScoreBoard);
            Debug.Log("Set Callback");
        }

        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _model.datas.Add(new SocoreBoardData("Data", 10));
                RefreshScoreBoard();
            }

        }
        protected override void InitRenderModel(IScoreBoard_Model model)
        {
            RefreshScoreBoard();
        }
        protected override void UpdateRenderModel(IScoreBoard_Model model)
        {
            RefreshScoreBoard();
        }
    }
}
