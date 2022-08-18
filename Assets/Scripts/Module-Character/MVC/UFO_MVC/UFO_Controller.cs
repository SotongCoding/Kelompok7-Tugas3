using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using SpaceInvader.Messege;

namespace SpaceInvader.Character
{
    public class UFO_Controller : ObjectController<UFO_Controller, UFO_Model, IUFO_Model, UFO_View>
    {
        public override void SetView(UFO_View view)
        {
            view.TakeDamage += TakeDamage;
            base.SetView(view);
        }
        private void TakeDamage()
        {
            Publish<UfoTakeDamageMessage>(new UfoTakeDamageMessage());
        }
    }
}


