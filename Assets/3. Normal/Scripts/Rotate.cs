using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	private float _targetAngle = 0f;
	private float _delay = 1f;

	private void Update()
	{
		_delay -= Time.deltaTime;
		if(_delay <= 0f)
		{
			_targetAngle = Random.Range(45f, 270f);
			_delay = Random.Range(1f, 2f);
		}

		transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, 0f, _targetAngle), Time.deltaTime * 10f);
	}
}
