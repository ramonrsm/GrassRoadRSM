using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManeger : MonoBehaviour {

	public static CheckPointManeger instance;
	[Header("CheckPoint")]

	public GameObject Player;
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

		StartCoroutine("InicializarCheckPoints");
	}

	public void ReposicionarPlayer(){
		if(checkPointAtual == 0){
			Player.transform.position = Vector3.zero;
		}else{
			Player.transform.position = posCheckPoints[checkPointAtual-1];
		}
	}

	public void ActiveCheckPoint(){

		checkPointAtual++;
		MoverCheckPoints(checkPointAtual);
	}

	private void MoverCheckPoints(int pos){

		if(pos >= posCheckPoints.Count){
			pos = 0;
		}

		for(int i = 0; i < posCheckPoints.Count; i++){

            if(!checkPoint.activeInHierarchy){
				checkPoint.transform.position = posCheckPoints[pos];
            	checkPoint.SetActive(true);
			}
		}
	}

	public IEnumerator InicializarCheckPoints(){

        yield return new WaitUntil(() => checkPoint != null);

		for(int i = 0; i < posCheckPoints.Count; i++){

            if(!checkPoint.activeInHierarchy){
				checkPoint.transform.position = posCheckPoints[i];
            	checkPoint.SetActive(true);
			}
		}
	}
}
