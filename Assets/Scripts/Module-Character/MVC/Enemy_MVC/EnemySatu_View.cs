using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Pooling;

namespace SpaceInvader.Character
{
    public class EnemySatu_View : ObjectView<IEnemySatu_Model>, IMoveable, IAttackable
    {
        private bool changeDirection;
        private int counter = 0;
        private Vector3 down = Vector2.right;
        [SerializeField] GameObject bulletPrefabs;
        private ActivateEnemy Shooter;
        private List<GameObject> Enemyship;
        public System.Action TakeDamage;
        public System.Action ShootBullet;
        public void Attack()
        {
            StartCoroutine(SpawnBulletEnemy());
        }

        public void Move(Transform T)
        {
            if (changeDirection)
            {
                transform.Translate(Vector2.right * 10 * 0.5f * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.left * 10 * 0.5f * Time.deltaTime);
            }
            if (T.position.x <= -5)
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
            else if (T.position.x >= 0)
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
        public void MoveDown()
        {
            down.x *= -1f;
            Vector3 pos = transform.position;
            pos.y -= 1f;
            transform.position = pos;
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
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag ("Bullet"))
            {
                TakeDamage?.Invoke();
            }    
        }

        protected override void InitRenderModel(IEnemySatu_Model model)
        {
            
        }

        protected override void UpdateRenderModel(IEnemySatu_Model model)
        {
            
        }
        private void Update()
        {
            Move(this.transform);
            
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
    }
}


