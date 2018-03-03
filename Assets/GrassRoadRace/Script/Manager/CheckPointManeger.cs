using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManeger : MonoBehaviour {

	public static CheckPointManeger instance;
	public List<Vector3>	positonCheckPoint;
	public int currentCheckPoint = 0;
	public GameObject	checkPoint;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		checkPoint = (GameObject)Instantiate(checkPoint);
		checkPoint.SetActive(false);

		ActiveCheckPoint();
	}

	public void ActiveCheckPoint(){

		if(!checkPoint.activeInHierarchy && currentCheckPoint < positonCheckPoint.Count){
			checkPoint.transform.position = positonCheckPoint[currentCheckPoint];
			checkPoint.SetActive(true);
			currentCheckPoint++;
			Debug.Log("Check point Atualizado");
		}
	}
}
