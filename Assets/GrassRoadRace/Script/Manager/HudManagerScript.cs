using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManagerScript : MonoBehaviour {
	
	public  static HudManagerScript instance;
	private GameController gameController;
	public  Slider 	 sliderFase;
	public  Text	 textColetavel;
	private int 	 coletavel;
	private float 	 valorSlider;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		gameController = GetComponent<GameController>();
		sliderFase.maxValue = gameController.finalFase.position.z * -1;
		sliderFase.minValue = gameController.inicioFase.position.z;
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
