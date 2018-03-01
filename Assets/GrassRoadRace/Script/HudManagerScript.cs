using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManagerScript : MonoBehaviour {

	public static HudManagerScript instance = null;
	public Text	textMoedas;
	public int 	coletavel;

	void Awake()
	{
		if(instance == null){
			instance = this;
		}else{
			instance = null;
		}
	}

	public HudManagerScript GetInstance(){
		
		if(instance == null){
			instance = this;
			return instance;
		}else{
			return null;
		}
	}

	void Start()
	{
		coletavel = 0;
		AtualizarColetavel();
	}

	// HUD
	public void AdicionarColetavel(int moedas){
		this.coletavel += moedas;
		AtualizarColetavel();
	}

	public void AtualizarColetavel(){
		textMoedas.text = coletavel.ToString();
	}
}
