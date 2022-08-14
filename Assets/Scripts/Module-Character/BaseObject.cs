using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using SpaceInvader.Gameplay.PlayerStatus;
//using Agate.MVC.Base;

namespace SpaceInvader.Character
{
    public abstract class BaseObject : MonoBehaviour, IMoveable, IAttackable, IDamageable
    {
        protected int speed = 10;
        protected int damage;
        protected int attackDamage;
//		protected PlayerStatus_Model lifeStatus;

        public abstract void Attack();

        public abstract void Move();

        public virtual void ObjectDestroy()
        {
            Destroy(this.gameObject);
        }

        public virtual void TakeDamage()
        {
//			lifeStatus.ReduceHealth();
        }
//		public void SetDepedency(PlayerStatus_Model lifeCounter)
//		{
//			lifeStatus = lifeCounter;
//		}

        // Update is called once per frame
        void Update()
        {
            Move();
            TakeDamage();

        }
    }
}

