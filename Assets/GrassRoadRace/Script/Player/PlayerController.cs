using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	HudManagerScript hudManager;
	MoedasManager moedasManager;
	CheckPointManeger checkPointManeger;

	GameController gameController;

	public float limiteYPlayer;

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

		// Checar se o player está abaixo do limite.
		if(transform.position.y <= limiteYPlayer){
			PosicaoSalva();
		}
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
