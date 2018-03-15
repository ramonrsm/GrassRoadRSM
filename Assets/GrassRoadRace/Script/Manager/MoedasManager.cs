using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedasManager : MonoBehaviour {

	public static MoedasManager instance;
	private PoolObjects poolObjects;

	private HudManagerScript hudManager;

	public int moedasAtuais;
	public int moedasFase;
	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		hudManager = HudManagerScript.instance;
		poolObjects = PoolObjects.instance;
	}

	public List<GameObject> GetMoedas(){

		List<GameObject> list = new List<GameObject>();
		GameObject objectPool = null;

		for(int i = 0; i < poolObjects.pooledObjects.Count; i++){

            if(poolObjects.pooledObjects[i].activeInHierarchy && poolObjects.pooledObjects[i].tag == "Moeda"){
				objectPool = poolObjects.pooledObjects[i];
				list.Add(objectPool);
			}
        }

		return list;
	}

	public void AdicionarMoeda(int coletavel){
		moedasAtuais+=coletavel;
		hudManager.AtualizarColetavel(moedasAtuais);
	}
}
