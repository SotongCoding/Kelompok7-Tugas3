using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Character
{
    public abstract class BaseAlien : BaseObject
{
        bool changeDirection;
        public override void Attack()
        {
            
        }

        public override void Move()
        {
            if (changeDirection)
            {
                transform.Translate(Vector2.right * speed * 1 * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.left * speed * 1 * Time.deltaTime);
            }
            if (this.gameObject.transform.position.x <= 0)
            {
                changeDirection = true;
            }
            else if (this.gameObject.transform.position.x >= 2)
            {
                changeDirection = false;
            }
        }

    

        // Update is called once per frame
        void Update()
        {

        }
    }
}

