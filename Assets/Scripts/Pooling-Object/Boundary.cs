using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Pooling
{
    public class Boundary : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Bullet"))
            {
                Destroy(col.gameObject);
            }
        }
    }
}

