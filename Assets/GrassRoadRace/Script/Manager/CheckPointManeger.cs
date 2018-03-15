using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManeger : MonoBehaviour {

	public static CheckPointManeger instance;

	private PoolObjects poolObjects;
	public GameObject checkPoint;
	public int checkPointAtual = 0;

	public List<Vector3> posCheckPoints;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		poolObjects = PoolObjects.instance;
		StartCoroutine("MoverCheckPoint");
	}

	public IEnumerator MoverCheckPoint(){

        yield return new WaitUntil(() => poolObjects != null);

		checkPoint = GetCheckPoint();

		for(int i = 0; i < posCheckPoints.Count; i++){

            if(!checkPoint.activeInHierarchy && checkPointAtual < posCheckPoints.Count){
				checkPoint.transform.position = posCheckPoints[checkPointAtual];
            	checkPoint.SetActive(true);
			}
		}
	}

	public GameObject GetCheckPoint(){

		for(int i = 0; i < poolObjects.pooledObjects.Count; i++){

            if(!poolObjects.pooledObjects[i].activeInHierarchy && poolObjects.pooledObjects[i].tag == "CheckPoint"){
				checkPoint = poolObjects.pooledObjects[i];
			}
        }
		return checkPoint;
	}

	public void ActiveCheckPoint(){
		checkPointAtual++;
		if(checkPointAtual > posCheckPoints.Count-1)
		checkPointAtual = 0;
		StartCoroutine("MoverCheckPoint");
	}
}
