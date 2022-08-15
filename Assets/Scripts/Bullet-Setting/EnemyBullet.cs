using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.BulletSetting
{
	public class EnemyBullet : MonoBehaviour
	{
		[SerializeField] private float bulletSpeed = 0.5f;
		// Start is called before the first frame update
		void Start()
		{
			
		}

		// Update is called once per frame
		void Update()
		{
			transform.Translate (Vector2.down * bulletSpeed * Time.deltaTime);
		}
		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.CompareTag("Player"))
			{
				Destroy(gameObject);
			}
		}
	}
}

