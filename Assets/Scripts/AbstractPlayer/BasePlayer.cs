using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class BasePlayer : MonoBehaviour{
	[SerializeField] private float jumpForce = 20.0f;

	public Rigidbody rb;

	private void Start(){
		rb = GetComponent<Rigidbody>();
	}

	private void Update(){
		if(Input.GetKeyDown("space"))
			MakeJump();
	}

	private void FixedUpdate(){
		ExtraActions();
	}

	private void MakeJump(){
		rb.AddForce(transform.up * jumpForce);
	}

	public abstract void ExtraActions();
}
