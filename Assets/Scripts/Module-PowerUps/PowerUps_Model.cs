using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Core;
using Agate.MVC.Base;

namespace SpaceInvader.PowerUps
{
    public class PowerUps_Model : BaseModel, IPowerUps_Model
    {
        public virtual float dropSpeed => 2;

        public virtual void OnPick()
        {

        }
    }
}
