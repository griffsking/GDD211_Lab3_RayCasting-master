using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
	private void Update()
	{
		transform.eulerAngles += new Vector3(0f, 0f, Mathf.Cos(Time.time) * 0.1f);

		RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

		if (hit)
		{
			Debug.DrawLine(transform.position, hit.point, Color.red);

			Debug.DrawLine(hit.point, hit.normal * 100f, Color.red);
		}
		else
		{
			Debug.DrawRay(transform.position, transform.up * 100f, Color.red);
		}
	}
}
