using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColetavelManager : MonoBehaviour {

	public static ColetavelManager instance;

	public List<GameObject> pooledObjects;
	public GameObject	objectToPool;
	public int amountToPool;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		pooledObjects = new List<GameObject>();

		for (int i = 0; i < amountToPool; i++) {
			GameObject obj = (GameObject)Instantiate(objectToPool);
			obj.SetActive(false); 
			pooledObjects.Add(obj);
		}
		distribuirColetaveis("Moeda");
	}

	public GameObject GetPooledObject(string tag) {

		for (int i = 0; i < pooledObjects.Count; i++) {
			
			if (!pooledObjects[i].activeInHierarchy && pooledObjects[i].tag == tag) {
				return pooledObjects[i];
			}
		} 
		return null;
	}

	public void distribuirColetaveis(string tag){

		int posZ = 0;
		
		for(int i = 0; i < pooledObjects.Count; i++){

            objectToPool = GetPooledObject(tag);
            objectToPool.transform.position = new Vector3(Random.Range(-1, 2), objectToPool.transform.position.y, posZ-1);

            if(Random.Range(0, 2) == 1){
                objectToPool.SetActive(true);
            }
            posZ--;
        }
	}
}
