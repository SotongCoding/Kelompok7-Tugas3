using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using System;

namespace SpaceInvader.PowerUps
{
    public class PowerUps_Controller : ObjectController<PowerUps_Controller, PowerUps_Model, IPowerUps_Model, PowerUps_View>
    {
        //private ScoreBoard.ScoreBoard_Controller _player;
        public void Init(PowerUps_Model model, PowerUps_View view)
        {
            _model = model;
            SetView(view);

            view.onPick += PubMes_PickPowerUp;
            view.onPick += DestroyPU;

            view.MovePowerUp();

        }

        void DestroyPU()
        {
            MonoBehaviour.Destroy(_view.gameObject);
        }

        private void PubMes_PickPowerUp()
        {
            Publish<Messege.RecivePowerUpMessege>(new Messege.RecivePowerUpMessege(
                _model.powerUpId,
                _model.duration
            )); 
        }
    }
}
