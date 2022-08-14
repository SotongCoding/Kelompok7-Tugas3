using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Character
{
    public class BaseAlien : BaseObject
{
		[SerializeField] protected Transform Muzzle;
		[SerializeField] protected GameObject bulletPrefabs;
        bool changeDirection;

		public override void Attack()
        {
			Instantiate (bulletPrefabs, Muzzle.position, Muzzle.rotation);
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
			Attack();
        }
    }
}

