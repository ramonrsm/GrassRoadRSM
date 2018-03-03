using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManeger : MonoBehaviour {

	public static CheckPointManeger instance;

	public List<Vector3>	positonCheckPoint;
	public bool coletado = false;

	public int amountCheckPoint;
	public int currentCheckPoint = 0;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		amountCheckPoint = positonCheckPoint.Count;
	}

	void Update()
	{
		if(currentCheckPoint > amountCheckPoint){
			currentCheckPoint = amountCheckPoint;
		}

		if(coletado == true && currentCheckPoint < amountCheckPoint){
			AtualizarCheckPoint();
		}
	}

	public void AtualizarCheckPoint(){
		Debug.Log("Check point Atualizado");
		ColetavelManager.instance.GetCheckPointPooledObject(positonCheckPoint[currentCheckPoint]);
		currentCheckPoint++;
		coletado = false;
	}
}
