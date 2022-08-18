using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Character
{
    public class Character_Model : BaseModel, ICharacter_Model
    {
        protected int speed = 10;

        public void CharacterMove(Transform T, bool CanMove)
        {
            if (CanMove == true)
            {
                T.Translate(Vector2.right * speed * 1 * Time.deltaTime);
            }
            else if (CanMove == false)
            {
                T.Translate(Vector2.left * speed * 1 * Time.deltaTime);
            }
        }

        public virtual void ObjectDestroy()
        {
            
        }

        public virtual void TakeDamage()
        {
            
        }

    }

}
