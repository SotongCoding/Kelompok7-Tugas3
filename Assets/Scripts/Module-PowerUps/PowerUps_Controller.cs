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
        internal void Init(PowerUps_Model model, PowerUps_View view)
        {
            _model = model;
            SetView(view);
        }
    }
}
