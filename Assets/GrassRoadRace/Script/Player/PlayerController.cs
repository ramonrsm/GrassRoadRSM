using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	HudManagerScript hudManager;
	CheckPointManeger checkPointManeger;

	void Start()
	{
		hudManager = HudManagerScript.instance;
		checkPointManeger = CheckPointManeger.instance;
	}

	void Update () {
		// Atualização posição atual na fase
		hudManager.AtualizarSlider(transform.position.z);
	}

	
	void OnTriggerEnter(Collider other)
	{
		switch(other.tag){

			case "Moeda":
				hudManager.AdicionarColetavel(1);
			break;
			case "CheckPoint":
				checkPointManeger.ActiveCheckPoint();
			break;
		}
	}
}
