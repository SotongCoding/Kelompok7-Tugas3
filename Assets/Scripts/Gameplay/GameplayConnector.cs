using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

using SpaceInvader.Gameplay.PlayerStatus;
using SpaceInvader.Messege;

namespace SpaceInvader.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        //Sound

        public void OnUpdateHealth(UpdateHealthMessege message)
        {

        }
        public void OnUpdateScore(UpdateScoreMessege message)
        {

        }

        protected override void Connect()
        {
            Subscribe<UpdateHealthMessege>(OnUpdateHealth);
            Subscribe<UpdateScoreMessege>(OnUpdateScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateHealthMessege>(OnUpdateHealth);
            Unsubscribe<UpdateScoreMessege>(OnUpdateScore);
        }
    }
}