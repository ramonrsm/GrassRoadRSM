using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	HudManagerScript hudManager;
	CheckPointManeger checkPointManeger;
	MoedasManager moedasManager;

	public Transform limiteYPlayer;

	void Start()
	{
		hudManager		  = HudManagerScript.instance;
		checkPointManeger = CheckPointManeger.instance;
		moedasManager 	  = MoedasManager.instance;
	}

	void Update () {

		// Atualização posição atual na fase
		hudManager.AtualizarSlider(transform.position.z);

		// Checar Posicao Y
		if(transform.position.y < limiteYPlayer.position.y){
			checkPointManeger.carregarPosicao();
		}
	}

	
	void OnTriggerEnter(Collider other)
	{
		switch(other.tag){

			case "Moeda":
				moedasManager.AdicionarMoeda(1);
			break;
			case "CheckPoint":
				//checkPointManeger.ActiveCheckPoint();
			break;
		}
	}
}
