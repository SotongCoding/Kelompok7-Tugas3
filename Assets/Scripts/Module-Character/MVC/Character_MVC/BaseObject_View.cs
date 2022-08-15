using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Character
{
    public class BaseObject_View : ObjectView<IBaseObject_Model>, IMoveable, IAttackable
    {
        [SerializeField] GameObject bulletPrefabs;
        public System.Action TakeDamage;
        public System.Action ShootBullet;
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
                Instantiate(bulletPrefabs, transform.position, Quaternion.identity);
                
            }
        }
    }
}


