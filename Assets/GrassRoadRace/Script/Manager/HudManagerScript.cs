using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManagerScript : MonoBehaviour {
	
	public static HudManagerScript instance;
	public Transform inicioFase, finalFase;
	public Slider sliderFase;
	public Text	textColetavel;
	public int 	coletavel;
	public float valorSlider;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		sliderFase.maxValue = finalFase.position.z * -1;
		sliderFase.minValue = inicioFase.position.z;

		coletavel = PlayerPrefs.GetInt("Moedas");
	}

	void Update()
	{
		valorSlider = sliderFase.value;
	}
	public void AtualizarSlider(float value){
		this.sliderFase.value = value *-1;
	}

	public void AtualizarColetavel(int coletavel){
		this.textColetavel.text = coletavel.ToString();
	}
}
