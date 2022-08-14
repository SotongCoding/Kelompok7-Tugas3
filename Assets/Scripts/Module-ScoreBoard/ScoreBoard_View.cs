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
        [SerializeField] Button showLeaderBoard;


        public void ShowScoreBoard()
        {
            RefreshScoreBoard();
        }

        void RefreshScoreBoard(){

        }

        public void SetButtonCallback()
        {
            showLeaderBoard.onClick.RemoveAllListeners();

            showLeaderBoard.onClick.AddListener(ShowScoreBoard);
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
