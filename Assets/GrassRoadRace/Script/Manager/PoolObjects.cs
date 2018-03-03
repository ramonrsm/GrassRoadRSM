using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoolObjects : MonoBehaviour {

	public static PoolObjects instance;
	public int amountToPool;
	public List<GameObject> pooledObjects;
	public GameObject	objectToPool;
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
	}

	public GameObject GetPooledObject(string tag) {

		for (int i = 0; i < pooledObjects.Count; i++) {
			
			if (!pooledObjects[i].activeInHierarchy && pooledObjects[i].tag == tag) {
				return pooledObjects[i];
			}
		} 
		return null;
	}
}
