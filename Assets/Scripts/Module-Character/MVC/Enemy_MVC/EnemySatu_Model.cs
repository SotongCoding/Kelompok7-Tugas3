using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Pooling;

namespace SpaceInvader.Character
{
    public class EnemySatu_Model : BaseModel, IEnemySatu_Model
    {
        protected int speed = 8;
        private bool changeDirection;
        private int counter = 0;
        private List<GameObject> Enemyship;
        public void EnemyMove(Transform T)
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
                if (counter >= 8)
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
                if (counter >= 8)
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
        public void MoveDown(Transform T)
        {
            Vector3 pos = T.position;
            pos.y -= 1f;
            T.position = pos;
        }

        public void ObjectDestroy()
        {
            
        }

        public void SpawnBullet(GameObject bulletPrefabs)
        {
            var alienShip = Enemyship[Random.Range(0, Enemyship.Count)];
            MonoBehaviour.Instantiate(bulletPrefabs, alienShip.transform.position, Quaternion.identity);
        }
        public void Generate(List<GameObject> Enemyship)
        {
            this.Enemyship = Enemyship;
        }
        public void TakeDamage()
        {
            
        }

    }
}


