﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManagerScript : MonoBehaviour {
	
	public Transform inicioFase, finalFase;
	public Slider sliderFase;
	public Text	textColetavel;
	public int 	coletavel;
	public float valorSlider;

	void Start()
	{
		sliderFase.maxValue = finalFase.position.z * -1;
		sliderFase.minValue = inicioFase.position.z;

		coletavel = 0;
		AtualizarColetavel();
	}

	void Update()
	{
		valorSlider = sliderFase.value;
	}

	public void AdicionarColetavel(int moedas){
		this.coletavel += moedas;
		AtualizarColetavel();
	}

	public void AtualizarColetavel(){
		textColetavel.text = coletavel.ToString();
	}

	public void AtualizarSlider(float value){
		this.sliderFase.value = value *-1;
	}
}
