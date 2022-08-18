using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Character
{
    public class Shield_View : BaseView, IDamageable
    {
        
        public System.Action damaged;
        public System.Action regenerate;
        public void ObjectDestroy()
        {
            Destroy(this.gameObject);
        }

        public void TakeDamage()
        {

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("EnemyBullet"))
            {
                damaged?.Invoke();
            }
        }
        public void RegenerateShield()
        {
            regenerate?.Invoke();
        }
        private void Start()
        {
            Shield_Controller control = new Shield_Controller();
            DependencyInjection.Instance.InjectDependencies(control);
            control.init(this);
        }
        private void Update()
        {
            
        }
    }
}


