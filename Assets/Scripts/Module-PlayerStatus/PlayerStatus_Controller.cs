using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using SpaceInvader.Messege;

namespace SpaceInvader.Gameplay.PlayerStatus
{
    public class PlayerStatus_Controller : ObjectController<PlayerStatus_Controller, PlayerStatus_Model, IPlayerStatus_Model, PlayerStatus_View>
    {
        public void ScoreKilledEnemy(int value)
        {
            _model.AddScore(value);
            Publish<UpdateScoreMessege>(new UpdateScoreMessege(_model.currentScore));
        }
        public void ReduceHealth()
        {
            _model.ReduceHealth();
            Publish<UpdateHealthMessege>(new UpdateHealthMessege(_model.playerHealth));
        }
    }
}
