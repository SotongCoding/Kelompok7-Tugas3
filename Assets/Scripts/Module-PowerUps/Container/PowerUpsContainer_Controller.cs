using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using UnityEngine;

namespace SpaceInvader.PowerUps
{

    public class PowerUps_ControllerContainer : BaseController<PowerUps_ControllerContainer>
    {
        PowerUps_Model[] avaiablePowerUp = new PowerUps_Model[]{
            new PU_PiercingShoot(),
        };

        public void SpawnPowerUp(PowerUps_View createdPowerUp)
        {
            PowerUps_Model powerUp = avaiablePowerUp[Random.Range(0, avaiablePowerUp.Length)];
            GameObject instanceObject = GameObject.Instantiate(createdPowerUp).gameObject;
            PowerUps_Controller instance = new PowerUps_Controller();

            InjectDependencies(instance);

            instance.Init(powerUp, createdPowerUp);
        }

    }
}
