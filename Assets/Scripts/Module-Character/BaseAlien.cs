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
            StartCoroutine(SpawnBulletEnemy());
        }

        public override void Move()
        {
            if (changeDirection)
            {
                transform.Translate(Vector2.right * speed * 0.5f * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.left * speed * 0.5f * Time.deltaTime);
            }
            if (this.gameObject.transform.position.x <= -1)
            {
                changeDirection = true;
            }
            else if (this.gameObject.transform.position.x >= 3)
            {
                changeDirection = false;
            }
        }

        IEnumerator SpawnBulletEnemy()
        {
            Instantiate(bulletPrefabs, Muzzle.position, Muzzle.rotation);
            yield return new WaitForSeconds(7f);
        }

        // Update is called once per frame
        
    }
}

