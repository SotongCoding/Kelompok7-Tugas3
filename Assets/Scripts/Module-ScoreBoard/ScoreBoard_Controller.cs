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

            //view.testingAddScore.onClick.AddListener(AddSampleScore);
        }

        // void AddSampleScore()
        // {
        //     Publish<Messege.AddNewScoreMessege>(
        //         new Messege.AddNewScoreMessege(
        //             "Name", 10)
        //         );
        // }
        public override IEnumerator Initialize()
        {
            _model.LoadData();
            return base.Initialize();
        }
    }
}
