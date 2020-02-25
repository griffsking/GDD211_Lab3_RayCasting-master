using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEnemyColor : MonoBehaviour
{
	public SpriteRenderer Sprite;

	private void Update()
	{
		transform.eulerAngles += new Vector3(0f, 0f, Time.deltaTime * 35f);

		RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

		if(hit)
		{
			Enemy hitEnemy = hit.collider.GetComponent<Enemy>();
			if (hitEnemy)
			{
				Sprite.color = hitEnemy.Sprite.color;
			}
		}
	}
}
