using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using UnityEngine;

namespace SpaceInvader.PowerUps
{

    public class PowerUps_ControllerContainer : BaseController<PowerUps_ControllerContainer>
    {
        #region Messege Reciver
        public void SpawnPowerUp(Messege.SpawnPowerUpMessege messege)
        {
            SpawnPowerUp(messege.powerUpObject, messege.spawnPos);
        }
        #endregion

        PowerUps_Model[] avaiablePowerUp = new PowerUps_Model[]{
            new PU_PiercingShoot(),
        };

        private void SpawnPowerUp(PowerUps_View createdPowerUp_view, Vector2 spawnLocation)
        {
            PowerUps_Model model = avaiablePowerUp[Random.Range(0, avaiablePowerUp.Length)];
            PowerUps_View instanceObject = GameObject.Instantiate(createdPowerUp_view);

            PowerUps_Controller instance = new PowerUps_Controller();

            InjectDependencies(instance);

            instance.Init(model, instanceObject);
        }



    }
}
