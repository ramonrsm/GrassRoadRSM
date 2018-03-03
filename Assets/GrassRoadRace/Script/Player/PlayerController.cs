using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {



	void Update () {
		// Atualização posição atual na fase
		HudManagerScript.instance.AtualizarSlider(transform.position.z);
	}

	
	void OnTriggerEnter(Collider other)
	{
		switch(other.tag){

			case "Moeda":
				HudManagerScript.instance.AdicionarColetavel(1);
			break;
			case "CheckPoint":
				CheckPointManeger.instance.coletado = true;
			break;
		}
	}
}
