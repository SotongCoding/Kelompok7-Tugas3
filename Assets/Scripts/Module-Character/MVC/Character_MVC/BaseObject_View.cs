using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.BulletSetting;

namespace SpaceInvader.Character
{
    public class BaseObject_View : ObjectView<IBaseObject_Model>, IMoveable, IAttackable
    {
        [SerializeField] Bullet_View[] bulletPrefabs;
        Bullet_View temp;
       
        public System.Action TakeDamage;
        public System.Action ShootBullet;
        public System.Action<Bullet_View, int> createBullet; 
        int i = 0;
        protected override void InitRenderModel(IBaseObject_Model model)
        {
           
        }

        protected override void UpdateRenderModel(IBaseObject_Model model)
        {
            
        }
        protected void Update()
        {
            Move(this.transform);
            Attack();
        }

        public void Move(Transform T)
        {
            if (Input.GetKey(KeyCode.RightArrow) && T.position.x <= 8)
            {
                transform.Translate(Vector2.right * 10 * 1 * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && T.position.x >= -8)
            {
                transform.Translate(Vector2.left * 10 * 1 * Time.deltaTime);
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag ("EnemyBullet"))
            {
                TakeDamage?.Invoke();
            }
        }

        public void Attack()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ShootBullet?.Invoke();
                createBullet?.Invoke(bulletPrefabs[i], i);

            }
        }
        public void ChangeBullet(int i)
        {
            this.i = i;
        }
        public void GetDuration(float duration)
        {
            StartCoroutine(TimeCounting());

            IEnumerator TimeCounting()
            {
                yield return new WaitForSeconds(duration);
                ChangeBullet(0);
            }
        }
    }
}


