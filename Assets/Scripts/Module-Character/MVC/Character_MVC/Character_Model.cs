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

        public void CharacterMove(Transform T)
        {
            if (Input.GetKey(KeyCode.RightArrow) && T.position.x <= 8)
            {
                T.Translate(Vector2.right * speed * 1 * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && T.position.x >= -8)
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
