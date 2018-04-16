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
	public GameObject 	panelWin, panelLose;

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

	public void Win(bool win){
		if(win){
			Time.timeScale = (Time.timeScale == 1) ? 0 : 1;
			panelWin.SetActive(win);
		}else{
			Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
			panelWin.SetActive(win);
		}
	}

	public void Lose(bool lose){
		if(lose){
			Time.timeScale = (Time.timeScale == 1) ? 0 : 1;
			panelLose.SetActive(lose);
		}else{
			Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
			panelLose.SetActive(lose);
		}
	}
}
