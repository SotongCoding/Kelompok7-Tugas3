using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Pooling;

namespace SpaceInvader.Character
{
    public class BaseAlien : BaseObject
    {
        [SerializeField] private List<GameObject> Enemyship;
        private ObjectPooling bulletPool;
        protected bool changeDirection;
        [SerializeField] protected GameObject bulletPrefabs;

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
            while (true)
            {
                var alienShip = Enemyship[Random.Range(0, Enemyship.Count)]; 
                Instantiate(bulletPrefabs, alienShip.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(2f);
            }
        }
        private void Start()
        {
            Attack();
        }



        // Update is called once per frame
    }
}

