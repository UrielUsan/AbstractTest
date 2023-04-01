using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : BasePlayer{
	[SerializeField] private float rotateSpeed = 10.0f;

	public override void ExtraActions(){
		if(!Physics.Raycast(transform.position, Vector3.down, 0.6f))
			transform.Rotate(Vector3.up, rotateSpeed * Time.fixedDeltaTime);
	}
}
