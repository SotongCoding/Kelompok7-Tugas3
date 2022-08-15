using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Character
{
    public class BaseObject_View : ObjectView<IBaseObject_Model>
    {
        protected override void InitRenderModel(IBaseObject_Model model)
        {
            _model = new Character();
        }

        protected override void UpdateRenderModel(IBaseObject_Model model)
        {
            
        }
        protected void Update()
        {
            _model.Move(this.transform);
        }
    }
}


