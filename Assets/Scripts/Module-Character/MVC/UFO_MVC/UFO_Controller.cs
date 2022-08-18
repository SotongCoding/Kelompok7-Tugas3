using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using SpaceInvader.Messege;
using System;

namespace SpaceInvader.Character
{
    public class UFO_Controller : ObjectController<UFO_Controller, UFO_Model, IUFO_Model, UFO_View>
    {
        private void TakeDamage()
        {
            Publish<UfoTakeDamageMessage>(new UfoTakeDamageMessage());
        }

        internal void Init(UFO_View ufo)
        {
            SetView(ufo);
            InjectDependencies(this);
            ufo.TakeDamage+= TakeDamage;
        }
    }
}


