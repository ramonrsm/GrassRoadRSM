using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManagerScript : MonoBehaviour {

	public static HudManagerScript instance = null;
	public Text	textMoedas;
	public Text textVidas;
	public int 	moedas, vidas;

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
		moedas = 0;
		vidas = 3;
		AtualizarMoedas();
		AtualizarVidas();
	}

	// HUD
	public void AdicionarMoeda(int moedas){
		this.moedas += moedas;
		AtualizarMoedas();
	}

	public void AdicionarVida(int vidas){
		this.vidas += vidas;
		AtualizarVidas();
	}

	public void AtualizarMoedas(){
		textMoedas.text = moedas.ToString();
	}

	public void AtualizarVidas(){
		textVidas.text = vidas.ToString();
	}
}
