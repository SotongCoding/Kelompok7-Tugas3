using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using UnityEngine;

namespace SpaceInvader.PowerUps
{

    public class PowerUps_ControllerContainer : BaseController<PowerUps_ControllerContainer>
    {
        #region Messege Reciver
        public void OnAlienShipDie(Messege.AlienTakeDamageMessage message)
        {
            SpawnPowerUp(message.destroyPosition);
        }
        #endregion

        PowerUps_Model[] avaiablePowerUp = new PowerUps_Model[]{
            new PU_PiercingShoot(),
        };

        private void SpawnPowerUp(Vector2 spawnLocation)
        {
            bool spawn = Random.Range(0, 101) <= 10;
            if (!spawn) return;

            PowerUps_Model model = avaiablePowerUp[Random.Range(0, avaiablePowerUp.Length)];
            PowerUps_View instanceObject = GameObject.Instantiate(Resources.Load<PowerUps_View>("prefabs/powerUpBase"));
            instanceObject.transform.position = spawnLocation;

            PowerUps_Controller instance = new PowerUps_Controller();
            InjectDependencies(instance);
            instance.Init(model, instanceObject);
        }



    }
}
