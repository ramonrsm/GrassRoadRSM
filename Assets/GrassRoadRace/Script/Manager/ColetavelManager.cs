using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColetavelManager : MonoBehaviour {

	public static ColetavelManager instance;

	public List<GameObject> pooledObjectsColetaveis;
	public GameObject	objectToPool;
	public GameObject	checkPoint;
	public int amountToPool;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		pooledObjectsColetaveis = new List<GameObject>();

		for (int i = 0; i < amountToPool; i++) {
			GameObject obj = (GameObject)Instantiate(objectToPool);
			obj.SetActive(false); 
			pooledObjectsColetaveis.Add(obj);
		}
		distribuirMoedas("Moeda");

		GameObject checkPointObj = (GameObject)Instantiate(checkPoint);
		checkPointObj.SetActive(false); 
		pooledObjectsColetaveis.Add(checkPointObj);
	}

	public GameObject GetPooledObject(string tag) {

		for (int i = 0; i < pooledObjectsColetaveis.Count; i++) {
			
			if (!pooledObjectsColetaveis[i].activeInHierarchy && pooledObjectsColetaveis[i].tag == tag) {
				return pooledObjectsColetaveis[i];
			}
		} 
		return null;
	}

	public void distribuirMoedas(string tag){

		int posZ = 0;
		
		for(int i = 0; i < pooledObjectsColetaveis.Count; i++){

            objectToPool = GetPooledObject(tag);
            objectToPool.transform.position = new Vector3(Random.Range(-1, 2), objectToPool.transform.position.y, posZ-1);

            if(Random.Range(0, 2) == 1){
                objectToPool.SetActive(true);
            }
            posZ--;
        }
	}

	public void GetCheckPointPooledObject(Vector3 position){

		objectToPool = GetPooledObject("CheckPoint");
		objectToPool.transform.position = position;
		objectToPool.SetActive(true);
	}
}
