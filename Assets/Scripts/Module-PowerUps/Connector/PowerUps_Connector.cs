using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace SpaceInvader.PowerUps
{
    public class PowerUps_Connector : BaseConnector
    {
        PowerUps_ControllerContainer _powerUpContainer;
        protected override void Connect()
        {
            Subscribe<Messege.SpawnPowerUpMessege>(_powerUpContainer.SpawnPowerUp);
        }

        protected override void Disconnect()
        {
            Unsubscribe<Messege.SpawnPowerUpMessege>(_powerUpContainer.SpawnPowerUp);
        }
    }
}