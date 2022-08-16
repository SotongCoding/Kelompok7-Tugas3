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
        public override void SetView(AlienShip_View view)
        {
            view.damaged += TakeDamage;
            base.SetView(view);
        }
        private void TakeDamage()
        {
            Publish<AlienTakeDamageMessage>(new AlienTakeDamageMessage());
        }
    }
}
