using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour
{
	public Transform Light;
	public ParticleSystem Sparks;

	private void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit))
		{
			//Use a position slightly off the surface to prevent clipping.
			Vector3 pos = Vector3.Lerp(hit.point, transform.position, 0.01f);

			Light.position = pos;

			ParticleSystem.EmitParams p = new ParticleSystem.EmitParams();
			p.position = pos;
			p.applyShapeToPosition = true;
			Sparks.Emit(p,4);
		}
	}
}
