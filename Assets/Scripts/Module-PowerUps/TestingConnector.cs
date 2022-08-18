using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

public class TestingConnector : BaseConnector
{
    SpaceInvader.PowerUps.PowerUps_ControllerContainer _powerUpSpawner;
    protected override void Connect()
    {
       Subscribe<SpaceInvader.Messege.SpawnPowerUpMessege>(_powerUpSpawner.SpawnPowerUp);
    }

    protected override void Disconnect()
    {
        Unsubscribe<SpaceInvader.Messege.SpawnPowerUpMessege>(_powerUpSpawner.SpawnPowerUp);
    }
}
