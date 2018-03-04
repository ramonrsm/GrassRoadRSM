using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoolObjects : MonoBehaviour {

	public static PoolObjects instance;
	[Header("Moedas")]
	public int amountMoedasToPool;
	public GameObject MoedasToPool;
	[Header("Obstáculos")]
	public int amountHurdleToPool;
	public GameObject HurdleToPool;
	public List<GameObject> pooledMoedasObjects;
	
	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		pooledMoedasObjects = new List<GameObject>();

		int totalObjectsToPool = amountMoedasToPool + amountHurdleToPool;

		for (int i = 0; i < totalObjectsToPool; i++) {

			if(i <= amountMoedasToPool){
				GameObject obj = (GameObject)Instantiate(MoedasToPool);
				obj.SetActive(false);
				pooledMoedasObjects.Add(obj);
			}else{
				GameObject obj = (GameObject)Instantiate(HurdleToPool);
				obj.SetActive(false);
				pooledMoedasObjects.Add(obj);
			}
		}
	}

	public GameObject GetPooledObject(string tag) {

		for (int i = 0; i < pooledMoedasObjects.Count; i++) {
			
			if (!pooledMoedasObjects[i].activeInHierarchy && pooledMoedasObjects[i].tag == tag) {
				return pooledMoedasObjects[i];
			}
		} 
		return null;
	}
}
