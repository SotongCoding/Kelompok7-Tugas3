using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Character
{
    public class BaseObject_View : ObjectView<IBaseObject_Model>, IMoveable
    {
        protected override void InitRenderModel(IBaseObject_Model model)
        {
           
        }

        protected override void UpdateRenderModel(IBaseObject_Model model)
        {
            
        }
        protected void Update()
        {
            Move(this.transform);
        }

        public void Move(Transform T)
        {
            if (Input.GetKey(KeyCode.RightArrow) && T.position.x <= 8)
            {
                transform.Translate(Vector2.right * 10 * 1 * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && T.position.x >= -8)
            {
                transform.Translate(Vector2.left * 10 * 1 * Time.deltaTime);
            }
        }
    }
}


