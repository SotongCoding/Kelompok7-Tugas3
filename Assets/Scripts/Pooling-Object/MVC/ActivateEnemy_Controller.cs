using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using SpaceInvader.Messege;
using SpaceInvader.Character;

namespace SpaceInvader.Pooling
{
    public class ActivateEnemy_Controller : ObjectController<ActivateEnemy_Controller,ActivateEnemy>
    {
        public void Spawn(AlienShipSpawnMessage ASSM)
        {
            AlienShip_View enemyShip = GameObject.Instantiate(ASSM.enemyPrefabs, ASSM.transform);
            AlienShip_Controller control = new AlienShip_Controller();

            enemyShip.killed += ASSM.allienKilled;
            Vector3 position = ASSM.rowPos;
            position.x += ASSM.column * 2.0f;
            enemyShip.transform.localPosition = position;
            ASSM.AS.Add(enemyShip.gameObject);

            control.init(enemyShip);

            InjectDependencies(control);
        }
        public void init()
        {
            _view.SpawnEvent += Publish;
            _view.Spawn();
        }
        public void Publish(AlienShipSpawnMessage MSG)
        {
            Publish<AlienShipSpawnMessage>(MSG);
        }
        
    }
}


