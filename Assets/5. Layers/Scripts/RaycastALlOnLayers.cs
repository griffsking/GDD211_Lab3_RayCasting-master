using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastALlOnLayers : MonoBehaviour
{
	public LayerMask LayerToHit;

	private void Update()
	{
		transform.eulerAngles = new Vector3(0f, 0f, Mathf.Cos(Time.time) * 90f);

		RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, transform.up, 100f, LayerToHit.value);
		Debug.DrawLine(transform.position, transform.up * 100f, Color.red);

		if (hits.Length > 0)
		{
			for (int i = 0; i < hits.Length; i++)
			{
				SpriteRenderer hitSprRend = hits[i].collider.GetComponent<SpriteRenderer>();
				if (hitSprRend)
				{
					hitSprRend.color = Color.red;
				}
			}
		}
	}
}
