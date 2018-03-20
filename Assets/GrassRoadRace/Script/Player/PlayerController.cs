using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	HudManagerScript hudManager;
	MoedasManager moedasManager;
	CheckPointManeger checkPointManeger;

	GameController gameController;

	public Transform limiteYPlayer;

	void Start()
	{
		hudManager		  = HudManagerScript.instance;
		moedasManager 	  = MoedasManager.instance;
		checkPointManeger = CheckPointManeger.instance;
		gameController 	  = GameController.instance;
		PosicaoSalva();
	}

	void Update () {

		// Atualização posição atual na fase
		hudManager.AtualizarSlider(transform.position.z);

		// Checar se o player caiu na água.
		gameController.limitesFase(this.transform, limiteYPlayer);
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
			case "AreaFinal":
				//GetComponent<PlayerMove>().podeMover = false;
				gameController.PausarJogo();
				
				//PosicaoSalva();
			break;
		}
	}

	public void PosicaoSalva(){
		if(checkPointManeger.checkPointAtual > 0){
			transform.position = checkPointManeger.posCheckPoints[checkPointManeger.checkPointAtual-1];
		}
	}
}
