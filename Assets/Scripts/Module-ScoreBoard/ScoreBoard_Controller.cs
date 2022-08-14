using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace SpaceInvader.ScoreBoard
{
    public class ScoreBoard_Controller : ObjectController<ScoreBoard_Controller, ScoreBoard_Model, IScoreBoard_Model, ScoreBoard_View>
    {
        public void AddNewScore(SocoreBoardData newData)
        {
            _model.StoreScore(newData);
        }
        public void ShowScoreBoard(){
            _view.ShowScoreBoard();
        }

        public override void SetView(ScoreBoard_View view)
        {
            base.SetView(view);
            view.SetButtonCallback();
        }
    }
}
