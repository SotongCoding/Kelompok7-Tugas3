using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Pooling;

namespace SpaceInvader.Character
{
    public class BaseAlien : BaseObject_Model
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
            var alienShip = Enemyship[Random.Range(0, Enemyship.Count)];
            GameObject.Instantiate(bulletPrefabs, alienShip.transform.position, Quaternion.identity);
        }

        public override void Move(Transform T)
        {
            if (changeDirection)
            {
                T.Translate(Vector2.right * speed * 0.5f * Time.deltaTime);
            }
            else
            {
                T.Translate(Vector2.left * speed * 0.5f * Time.deltaTime);
            }
            if (T.position.x <= -5)
            {
                changeDirection = true;
                if (counter >= 7)
               {
                    MoveDown(T);
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }
            else if (T.position.x >= 0)
            {
                changeDirection = false;
                if (counter >= 7)
                {
                    MoveDown(T);
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
                Attack();
                yield return new WaitForSeconds(2f);
            }
        }
        public virtual void MoveDown(Transform T)
        {
            down.x *= -1f;
            Vector3 pos = T.position;
            pos.y  -= 1f;
            T.position = pos;
        }
        private void Start()
        {
            Attack();
        }

        private void Awake()
        {
       //     Shooter = GetComponent<ActivateEnemy>();
            //Enemyship = Shooter.AS;
        }

        // Update is called once per frame
    }
}

