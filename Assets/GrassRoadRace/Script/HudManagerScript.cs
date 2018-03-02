using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManagerScript : MonoBehaviour {
	
	public Transform inicioFase, finalFase;
	public Slider sliderFase;
	public Text	textColetavel;
	public int 	coletavel;
	public float posPlayer;

	public float rangeSlider;

	void Start()
	{
		rangeSlider = finalFase.position.z - inicioFase.position.z;
		sliderFase.maxValue = rangeSlider;
		sliderFase.minValue = 0f;

		coletavel = 0;
		AtualizarColetavel();
	}

	public void AdicionarColetavel(int moedas){
		this.coletavel += moedas;
		AtualizarColetavel();
	}

	public void AtualizarColetavel(){
		textColetavel.text = coletavel.ToString();
	}

	public void PosicaoAtualSlider(float value){
		posPlayer += value;
		AtualizarSlider();
	}

	public void AtualizarSlider(){
		this.sliderFase.value += posPlayer;
	}
}
