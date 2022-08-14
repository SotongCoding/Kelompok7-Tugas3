using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace SpaceInvader.PowerUps
{
    public class PowerUps_Controller : ObjectController<PowerUps_Controller, PowerUps_Model, IPowerUps_Model, PowerUps_View>
    {
        public void Move()
        {
            _view.MovePowerUp();
        }
    }
}
