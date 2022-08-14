using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Character
{
    public class Character : BaseObject
    {
        
        public override void Move()
        {
            if (Input.GetKey(KeyCode.RightArrow) && this.gameObject.transform.position.x <= 8)
            {
                transform.Translate(Vector2.right * speed * 1 * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && this.gameObject.transform.position.x >= -8)
            {
                transform.Translate(Vector2.left * speed * 1 * Time.deltaTime);
            }
        }

        public override void ObjectDestroy()
        {
            base.ObjectDestroy();
        }
        public override void TakeDamage()
        {
            
        }
        public override void Attack()
        {
            if (Input.GetMouseButtonDown(0))
            {

            }
        }
    }
}

