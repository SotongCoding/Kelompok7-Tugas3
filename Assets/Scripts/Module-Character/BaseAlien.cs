using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Pooling;

namespace SpaceInvader.Character
{
    public class BaseAlien : BaseObject
    {
        private ActivateEnemy Shooter;
        private List<GameObject> Enemyship;
        private ObjectPooling bulletPool;
        protected bool changeDirection;
        protected Vector3 down = Vector2.right;
        [SerializeField] protected GameObject bulletPrefabs;

        protected int counter = 0;

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
            if (this.gameObject.transform.position.x <= -5)
            {
                changeDirection = true;
                if (counter >= 7)
                {
                    MoveDown();
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }
            else if (this.gameObject.transform.position.x >= 0)
            {
                changeDirection = false;
                if (counter >= 7)
                {
                    MoveDown();
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                
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
        private void MoveDown()
        {
            down.x *= -1f;
            Vector3 pos = this.transform.position;
            pos.y  -= 1f;
            this.transform.position = pos;
        }
        private void Start()
        {
            Attack();
        }

        private void Awake()
        {
            Shooter = GetComponent<ActivateEnemy>();
            Enemyship = Shooter.AS;
        }

        // Update is called once per frame
    }
}

