using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Character
{
    public class BaseObject_Model : BaseModel, IBaseObject_Model
    {
        protected int speed = 10;
        public virtual void Attack()
        {
            
        }

        public virtual void Move(Transform T)
        {
            
        }

        public virtual void ObjectDestroy()
        {
            
        }

        public virtual void TakeDamage()
        {
            
        }
    }

}
