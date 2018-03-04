using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	HudManagerScript hudManager;
	CheckPointManeger checkPointManeger;

	MoedasManager moedasManager;

	void Start()
	{
		hudManager		  = HudManagerScript.instance;
		checkPointManeger = CheckPointManeger.instance;
		moedasManager 	  = MoedasManager.instance;

		transform.position = checkPointManeger.carregarPosicao();
	}

	void Update () {
		// Atualização posição atual na fase
		hudManager.AtualizarSlider(transform.position.z);
	}

	
	void OnTriggerEnter(Collider other)
	{
		switch(other.tag){

			case "Moeda":
				moedasManager.AdicionarMoeda(1);
			break;
			case "CheckPoint":
				checkPointManeger.ActiveCheckPoint();
			break;
		}
	}
}
