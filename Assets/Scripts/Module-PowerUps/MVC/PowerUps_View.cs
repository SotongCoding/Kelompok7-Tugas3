using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using System;

namespace SpaceInvader.PowerUps
{
    public class PowerUps_View : ObjectView<IPowerUps_Model> // MonoBehaviour
    {
        public System.Action onPick;
        public System.Action Hancurkan;
        protected override void InitRenderModel(IPowerUps_Model model)
        {

        }

        protected override void UpdateRenderModel(IPowerUps_Model model)
        {

        }

        public void MovePowerUp()
        {
            StartCoroutine(TranslateObject());

            IEnumerator TranslateObject()
            {
                while (true)
                {
                    transform.Translate(Vector2.down * Time.deltaTime
                    * _model.dropSpeed);
                    yield return null;
                }

            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                onPick?.Invoke();
                //Hancurkan?.Invoke();
            }
        }
    }
}
