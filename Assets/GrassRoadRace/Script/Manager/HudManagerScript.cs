using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManagerScript : MonoBehaviour {
	
	public  static HudManagerScript instance;
	public  Slider 	 sliderFase;
	public  Text	 textColetavel;
	private int 	 coletavel;
	public Transform	inicioFase, finalFase;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		sliderFase.maxValue = finalFase.position.z * -1;
		sliderFase.minValue = inicioFase.position.z;
	}

	void Update()
	{
		float valorSlider = sliderFase.value;
	}
	public void AtualizarSlider(float value){
		this.sliderFase.value = value *-1;
	}

	public void AtualizarColetavel(int coletavel){
		this.textColetavel.text = coletavel.ToString();
	}
}
