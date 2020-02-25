using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
	private SpriteRenderer _spriteRend;
	private Color _startColor;

	private void Start()
	{
		_spriteRend = GetComponent<SpriteRenderer>();
		_startColor = _spriteRend.color;
	}

	void Update()
    {
		_spriteRend.color = Color.Lerp(_spriteRend.color, _startColor, Time.deltaTime * 4f);
    }
}
