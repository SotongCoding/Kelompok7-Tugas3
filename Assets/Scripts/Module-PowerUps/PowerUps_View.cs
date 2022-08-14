using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using System;

namespace SpaceInvader.PowerUps
{
    public class PowerUps_View : ObjectView<IPowerUps_Model>
    {
        protected override void InitRenderModel(IPowerUps_Model model)
        {

        }

        protected override void UpdateRenderModel(IPowerUps_Model model)
        {

        }

        internal void MovePowerUp()
        {
            transform.Translate(Vector2.down * Time.deltaTime
            * _model.dropSpeed);
        }
    }
}
