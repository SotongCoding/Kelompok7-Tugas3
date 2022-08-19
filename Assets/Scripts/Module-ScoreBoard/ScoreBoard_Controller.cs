using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace SpaceInvader.ScoreBoard
{
    public class ScoreBoard_Controller : ObjectController<ScoreBoard_Controller, ScoreBoard_Model, IScoreBoard_Model, ScoreBoard_View>
    {
        public void AddNewScore(Messege.SendScoreBoardScoreMessege messege)
        {
            _model.StoreScore(
                new SocoreData(
                    messege.playerName,
                    messege.currentScore
                ));

        }

        void ButtonEvent()
        {
            //Publish<Messege.SpawnPowerUpMessege>(new Messege.SpawnPowerUpMessege(_view.powerUpPrefab,Vector2.zero));
        }
        public override IEnumerator Initialize()
        {
            _model.LoadData();
            return base.Initialize();
        }
    }
}
