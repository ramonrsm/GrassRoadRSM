using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManeger : MonoBehaviour {

	private PoolObjects poolObjects;
	public static CheckPointManeger instance;
	public List<Vector3>	positonCheckPoint;
	public int currentCheckPoint;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		poolObjects = PoolObjects.instance;
	}

	void Update()
	{

	}

	/*public void ActiveCheckPoint(){

		GameObject obj = poolObjects.GetPooledObject("CheckPoint");

		if(!obj.activeInHierarchy && currentCheckPoint < positonCheckPoint.Count){
			obj.transform.position = positonCheckPoint[currentCheckPoint];
			obj.SetActive(true);
			currentCheckPoint++;
			Debug.Log("Check point Atualizado");
		}		
	}*/

	public Vector3 carregarPosicao(){
		
		return positonCheckPoint[currentCheckPoint];
	}
}
