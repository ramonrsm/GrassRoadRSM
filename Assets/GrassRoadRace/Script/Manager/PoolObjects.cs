using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoolObjects : MonoBehaviour {

	public static PoolObjects instance;
	[Header("Moedas")]
	public int quantidadeMoedas;
	public GameObject moedas;
	[Header("Obstáculos")]
	public int quantidadeObstaculos;
	public GameObject obstaculos;
	[Header("CheckPoint")]
	public GameObject checkPoint;

	public List<GameObject> pooledObjects;
	
	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		CriarPoolObjects();
	}

	private void CriarPoolObjects(){

		GameObject obj = (GameObject)Instantiate(checkPoint);
		obj.SetActive(false);
		pooledObjects.Add(obj);

		for (int i = 0; i < quantidadeMoedas; i++) {

			obj = (GameObject)Instantiate(moedas);
			obj.SetActive(false);
			pooledObjects.Add(obj);
		}

		for (int i = 0; i < quantidadeObstaculos; i++) {

			obj = (GameObject)Instantiate(obstaculos);
			obj.SetActive(false);
			pooledObjects.Add(obj);
		}
	}

	public List<GameObject> GetPooledObject(string tag) {

		List<GameObject> lista = new List<GameObject>();

		for (int i = 0; i < pooledObjects.Count; i++) {
			
			if (!pooledObjects[i].activeInHierarchy && pooledObjects[i].tag == tag) {
				lista.Add(pooledObjects[i]);
			}
		} 
		return lista;
	}
}
