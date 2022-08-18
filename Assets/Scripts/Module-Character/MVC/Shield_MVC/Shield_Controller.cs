using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Messege;

namespace SpaceInvader.Character
{
    public class Shield_Controller : ObjectController<Shield_Controller, Shield_View>
    {
        private int health = 2;

        public void init(Shield_View SV)
        {
            SetView(SV);
            _view.damaged += TakeDamage;
            _view.regenerate += RegenerateShield;
        }
        private void TakeDamage()
        {
            health--;
            if (health <= 0)
            {
                _view.gameObject.SetActive(false);
            }
            
        }
        private void RegenerateShield()
        {
            health = 2;
        }
    }
}
