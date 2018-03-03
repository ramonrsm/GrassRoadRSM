using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour {

	public float speedRotation = -80f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate((Vector3.up * speedRotation) * Time.deltaTime, Space.World);
	}
	void OnTriggerEnter(Collider other)
	{
		switch(other.tag){

			case "Player":
			gameObject.SetActive(false); 
			break;
		}
	}
}
