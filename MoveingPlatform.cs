using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{

	[SerializeField] private float speed;
	[SerializeField] private float startingPosition;
	[SerializeField] private float endPosition;

	private bool rightMove = true;

	private Vector3 pos;

	void Update()
	{
		transform.position += transform.right * speed * Time.deltaTime;
		if (pos.x > endPosition && rightMove)
		{
			rightMove = false;
			speed *= -1f;
		}
		if (pos.x < startingPosition && !rightMove)
		{
			rightMove = true;
			speed *= -1f;
		}
		pos = transform.position;
	}

	void OnCollisionEnter(Collision col)
	{
		col.gameObject.transform.parent = transform;
	}

	void OnCollisionExit(Collision col)
	{
		col.gameObject.transform.parent = null;
	}

}
