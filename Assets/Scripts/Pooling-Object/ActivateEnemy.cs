using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Character;

namespace SpaceInvader.Pooling
{
    public class ActivateEnemy : MonoBehaviour
    {
        [SerializeField] private AlienShip_View enemyPrefabs;
        private int rows = 3;
        private int columns = 6;
        public int amountKilled { get; private set; }
        [SerializeField] private int total => this.rows * this.columns;
        [SerializeField] private float percentKilled  => (float)this.amountKilled / (float)this.total;
        [SerializeField] GameObject parent;

        public List<GameObject> AS = new List<GameObject>();

        private void Awake()
        {
            Spawn();

        }
        private void RespawnEnemy()
        {

          Transform[] allChildren = GetComponentsInChildren<Transform>();
          foreach (Transform child in allChildren)
          {
              child.gameObject.SetActive(true);
          }
        }
    private void alienKilled()
        {
            this.amountKilled++;
        }
        private void Update()
        {
            
        }
        private void Spawn()
        {
            for (int row = 0; row < this.rows; row++)
            {
                float width = 1.0f * (this.columns - 1);
                float height = -1.0f * (this.rows - 1);

                Vector2 center = new Vector2(-width / 2, -height / 2);
                Vector3 rowPos = new Vector3(center.x, center.y + (row * 1.5f), 0.0f);

                for (int column = 0; column < this.columns; column++)
                {
                    AlienShip_View enemyShip = Instantiate(enemyPrefabs, transform);
                    enemyShip.killed += alienKilled;
                    Vector3 position = rowPos;
                    position.x += column * 2.0f;
                    enemyShip.transform.localPosition = position;
                    AS.Add(enemyShip.gameObject);
                }
            }
        }
    }
}

