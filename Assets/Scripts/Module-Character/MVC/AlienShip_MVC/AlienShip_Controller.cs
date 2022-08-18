using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Messege;

namespace SpaceInvader.Character
{
    public class AlienShip_Controller : ObjectController<AlienShip_Controller, AlienShip_View>
    {

        public void init(AlienShip_View view)
        {
            view.damaged += TakeDamage;
            SetView(view);
        }
        private void TakeDamage()
        {
            Publish<AlienTakeDamageMessage>(new AlienTakeDamageMessage(_view.transform.position));
            Publish<PlayAuidoMessege>(new PlayAuidoMessege("sfx_enemyDestroy"));
        }
    }
}
