using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPlayer : BasePlayer{
	public override void ExtraActions(){
		if(Input.GetKeyDown("space")){
			Renderer rend = GetComponent<Renderer>();
			
			rend.material.color = new Color32(
				(byte)Random.Range(0, 255),
				(byte)Random.Range(0, 255),
				(byte)Random.Range(0, 255),
				255
			);
		}
	}
}
