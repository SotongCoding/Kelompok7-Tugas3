using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Character
{
    public class Character : BaseObject_Model
    {
        [SerializeField] GameObject bulletPrefabs;
        [SerializeField] Transform Muzzle;
        /*public override void Move(Transform T)
        {
            if (Input.GetKey(KeyCode.RightArrow) && T.position.x <= 8)
            {
                T.Translate(Vector2.right * speed * 1 * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && T.position.x >= -8)
            {
                T.Translate(Vector2.left * speed * 1 * Time.deltaTime);
            }
        }*/

        
        /*public override void Attack()
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Instantiate(bulletPrefabs, Muzzle.position, Quaternion.identity);
            }
        }*/

        // public void TakeDamage()
        // {
            
        // }

        // public void ObjectDestroy()
        // {
        //     //Destroy(this.gameObject);
        // }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag ("EnemyBullet"))
            {
                //Destroy(gameObject);
            }
        }
        protected void Update()
        {
        //    Move();
        //    Attack();
        }
    }
}

