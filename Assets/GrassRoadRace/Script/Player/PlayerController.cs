using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	HudManagerScript hudManager;
	MoedasManager moedasManager;
	CheckPointManeger checkPointManeger;

	GameController gameController;

	public float limiteYPlayer;

	public bool pauseGame = false;

	void Start()
	{
		hudManager		  = HudManagerScript.instance;
		moedasManager 	  = MoedasManager.instance;
		checkPointManeger = CheckPointManeger.instance;
		gameController 	  = GameController.instance;

		limiteYPlayer = transform.position.y - 4.5f;
	}

	void Update () {

		// Atualização posição atual na fase
		hudManager.AtualizarSlider(transform.position.z);

<<<<<<< HEAD
		// Checar se o player está abaixo do limite.
		if(transform.position.y <= limiteYPlayer){
			PosicaoSalva();
		}
=======
		// Checar se o player caiu na água.
		if(gameController.PausarJogo()){
			hudManager.panelLose.SetActive(true);
		}
		//gameController.ReposicionarPlayer(this.transform, limiteYPlayer);
>>>>>>> 64f406a0ac4275db5017892ab7d0db1de2b81e78
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
<<<<<<< HEAD
				gameController.PausarJogo();
				//PosicaoSalva();
=======
				hudManager.panelWin.SetActive(true);
				gameController.PausarJogo();
>>>>>>> 64f406a0ac4275db5017892ab7d0db1de2b81e78
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
