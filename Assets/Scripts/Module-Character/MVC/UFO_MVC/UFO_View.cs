using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Character
{
    public class UFO_View : ObjectView<IUFO_Model>, IMoveable
    {
        private bool changeDirection;
        public System.Action TakeDamage;
        

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
            if (T.position.x <= -8)
            {
                changeDirection = true;
            }
            else if (T.position.x >= 10)
            {
                changeDirection = false;
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Bullet") || collision.CompareTag ("BatasUfo"))
            {
                TakeDamage?.Invoke();
                Destroy(gameObject);
            }
        }
      
        private void Update()
        {
            Move(this.transform);

        }
        private void Start()
        {
            
        }
        protected override void InitRenderModel(IUFO_Model model)
        {
            
        }

        protected override void UpdateRenderModel(IUFO_Model model)
        {
            
        }
    }
}

