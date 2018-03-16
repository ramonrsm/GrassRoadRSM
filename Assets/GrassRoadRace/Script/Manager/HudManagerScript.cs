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
	public GameObject 	painelAlerta;
	public Text			textTitulo, textoCorpo;
	public GameObject	iconePainel;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		painelAlerta.SetActive(false);
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

	public void PainelAlerta(string titulo, string texto){
		textTitulo.text = titulo;
		textColetavel.text = texto;
	}
	public void PainelAlerta(string titulo, string texto, bool icon){
		textTitulo.text = titulo;
		textColetavel.text = texto;
		iconePainel.SetActive(icon);
	}
}
