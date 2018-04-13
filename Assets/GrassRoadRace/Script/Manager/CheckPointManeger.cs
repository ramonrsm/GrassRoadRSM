using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManeger : MonoBehaviour {

	public static CheckPointManeger instance;
	[Header("CheckPoint")]
	public GameObject checkPoint;
	public int checkPointAtual = 0;

	public List<Vector3> posCheckPoints;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		checkPoint = (GameObject)Instantiate(checkPoint);
		checkPoint.SetActive(false);

		StartCoroutine("MoverCheckPoint");
	}

	public IEnumerator MoverCheckPoint(){

        yield return new WaitUntil(() => checkPoint != null);

		for(int i = 0; i < posCheckPoints.Count; i++){

            if(!checkPoint.activeInHierarchy && checkPointAtual < posCheckPoints.Count){
				checkPoint.transform.position = posCheckPoints[checkPointAtual];
            	checkPoint.SetActive(true);
			}
		}
	}

	public void ActiveCheckPoint(){
		checkPointAtual++;
		
		if(checkPointAtual > posCheckPoints.Count-1){
			checkPointAtual = 0;
		}
		
		StartCoroutine("MoverCheckPoint");
	}
}
