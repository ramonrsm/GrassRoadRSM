using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	HudManagerScript hudManager;
	MoedasManager moedasManager;
	CheckPointManeger checkPointManeger;

	GameController gameController;

	public Transform limiteYPlayer;

	public bool pauseGame = false;

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
		if(gameController.PausarJogo()){
			hudManager.panelLose.SetActive(true);
		}
		//gameController.ReposicionarPlayer(this.transform, limiteYPlayer);
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
				hudManager.panelWin.SetActive(true);
				gameController.PausarJogo();
			break;
		}
	}

	public void PosicaoSalva(){
		if(checkPointManeger.checkPointAtual > 0){
			pauseGame = true;
			transform.position = checkPointManeger.posCheckPoints[checkPointManeger.checkPointAtual-1];
		}
	}
}
