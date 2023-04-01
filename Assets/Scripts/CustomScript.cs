using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CustomScript : MonoBehaviour{
	[SerializeField] private float jumpForce = 20.0f;
	[SerializeField] private float rotateSpeed = 10.0f;
	
	[SerializeField] private bool rotate = false;
	[SerializeField] private bool swapColor = false;

	private Rigidbody rb;
	private Renderer render;

	private void Start(){
		rb = GetComponent<Rigidbody>();
		render = GetComponent<Renderer>();
	}

	private void Update(){
		if(Input.GetKeyDown("space")){
			MakeJump();

			if(swapColor)
				render.material.color = SwapColor();
		}
	}

	private void FixedUpdate(){
		if(rotate) RotatePlayer();
	}

	private void MakeJump(){
		rb.AddForce(transform.up * jumpForce);
	}

	private Color32 SwapColor(){
		return new Color32(
			(byte)Random.Range(0, 255),
			(byte)Random.Range(0, 255),
			(byte)Random.Range(0, 255),
			255
		);
	}

	private void RotatePlayer(){
		if(!Physics.Raycast(transform.position, Vector3.down, 0.6f))
			transform.Rotate(Vector3.up, rotateSpeed * Time.fixedDeltaTime);
	}
}
