using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace SpaceInvader.ScoreBoard
{
    public class ScoreBoard_Controller : ObjectController<ScoreBoard_Controller, ScoreBoard_Model, IScoreBoard_Model, ScoreBoard_View>
    {
        public void AddNewScore(Messege.AddNewScoreMessege messege)
        {
            _model.StoreScore(
                new SocoreData(
                    messege.playerName,
                    messege.currentPlayerScore
                ));

        }

        public override void SetView(ScoreBoard_View view)
        {
            base.SetView(view);
            view.SetButtonCallback();

            view.testingAddScore.onClick.AddListener(ButtonEvent);
        }

        void ButtonEvent()
        {
            Publish<Messege.SpawnPowerUpMessege>(new Messege.SpawnPowerUpMessege(_view.powerUpPrefab,Vector2.zero));
        }
        public override IEnumerator Initialize()
        {
            _model.LoadData();
            return base.Initialize();
        }
    }
}
