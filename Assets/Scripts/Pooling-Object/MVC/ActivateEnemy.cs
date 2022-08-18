using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Character;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Messege;

namespace SpaceInvader.Pooling
{
    public class ActivateEnemy : BaseView
    {
        [SerializeField] private AlienShip_View enemyPrefabs;
        private int rows = 3;
        private int columns = 6;
        public int amountKilled { get; private set; }
        [SerializeField] private int total => this.rows * this.columns;
        [SerializeField] private float percentKilled => (float)this.amountKilled / (float)this.total;
        [SerializeField] GameObject parent;
        [SerializeField] Shield_View[] shield;

        public List<GameObject> AS = new List<GameObject>();
        public System.Action<AlienShipSpawnMessage> SpawnEvent;

        private void Awake()
        {
            

        }
        private void RespawnEnemy()
        {
           if (amountKilled == 18)
           {
                parent.SetActive(false);
                if(parent.activeInHierarchy == false)
                {
                    gameObject.transform.position = new Vector3(-3, 0, 0);
                    parent.SetActive(true);
                    amountKilled = 0;
                    foreach(var respawn in AS)
                    {
                        respawn.SetActive(true);
                    }
                    foreach(Shield_View child in shield)
                    {
                        child.gameObject.SetActive(true);
                        child.RegenerateShield();
                    }
                }
                
            }
        }
    public void alienKilled()
        {
            this.amountKilled++;
        }
        private void Update()
        {
            RespawnEnemy();
            
        }
        public void Spawn()
        {
            for (int row = 0; row < this.rows; row++)
            {
                float width = 1.0f * (this.columns - 1);
                float height = -1.0f * (this.rows - 1);

                Vector2 center = new Vector2(-width / 2, -height / 2);
                Vector3 rowPos = new Vector3(center.x, center.y + (row * 1.5f), 0.0f);

                for (int column = 0; column < this.columns; column++)
                {
                    SpawnEvent?.Invoke(new AlienShipSpawnMessage(
                        rowPos,
                        column,
                        enemyPrefabs,
                        alienKilled,
                        this.transform,
                        AS
                        ));
                }
            }
        }
    }
}

