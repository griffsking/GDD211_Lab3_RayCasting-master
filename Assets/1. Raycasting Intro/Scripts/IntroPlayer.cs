using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPlayer : MonoBehaviour
{
	public SpriteRenderer Sprite;

	private void Update()
	{
		//Rotate
		transform.eulerAngles += new Vector3(0f, 0f, Time.deltaTime * 25f);
		
		RaycastHit2D hit = Physics2D.Raycast(transform.position,transform.up);

		if (hit)
		{
			Debug.DrawLine(transform.position, hit.point, Color.red);
			Sprite.color = Color.red;
		}
		else
		{
			Debug.DrawRay(transform.position, transform.up * 100f, Color.green);
			Sprite.color = Color.green;
		}
	}
}
