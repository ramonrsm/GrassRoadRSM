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

		coletavel = 0;
		AtualizarColetavel();
	}

	void Update()
	{
		valorSlider = sliderFase.value;
	}

	public void AdicionarColetavel(int coletavel){
		this.coletavel += coletavel;
		AtualizarColetavel();
	}

	public void AtualizarColetavel(){
		Debug.Log("Moedas Atualizada");
		textColetavel.text = coletavel.ToString();
	}

	public void AtualizarSlider(float value){
		this.sliderFase.value = value *-1;
	}
}
