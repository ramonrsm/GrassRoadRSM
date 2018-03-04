using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManeger : MonoBehaviour {

	public static CheckPointManeger instance;
	public List<Vector3>	positonCheckPoint;
	public int currentCheckPoint;
	public GameObject	checkPoint;

	public int posicaoSalva;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		//PlayerPrefs.SetInt("CheckPoint", 0);

		currentCheckPoint = PlayerPrefs.GetInt("CheckPoint");
		checkPoint = (GameObject)Instantiate(checkPoint);
		checkPoint.SetActive(false);
		ActiveCheckPoint();
	}

	void Update()
	{
		//PlayerPrefs.SetInt("CheckPoint", posicaoSalva);
		posicaoSalva = PlayerPrefs.GetInt("CheckPoint");
	}

	public void ActiveCheckPoint(){

		if(!checkPoint.activeInHierarchy && currentCheckPoint < positonCheckPoint.Count){
			salvarPosicao(currentCheckPoint);
			checkPoint.transform.position = positonCheckPoint[currentCheckPoint];
			checkPoint.SetActive(true);
			currentCheckPoint++;
			Debug.Log("Check point Atualizado");
		}		
	}

	public void salvarPosicao(int value){
		PlayerPrefs.SetInt("CheckPoint", value);
	}

	public Vector3 carregarPosicao(){

		int posicaoSalva = PlayerPrefs.GetInt("CheckPoint");

		if(posicaoSalva > 0){
			return positonCheckPoint[posicaoSalva];
		}else{
			return new Vector3(0, 0.51f, 0);
		}
	}
}
