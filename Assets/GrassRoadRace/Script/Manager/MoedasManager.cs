using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedasManager : MonoBehaviour {

	public static MoedasManager instance;
	private PoolObjects poolObjects;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		poolObjects = PoolObjects.instance;
		distribuirMoedas();
	}

	public void distribuirMoedas(){

		int posZ = 0;

		GameObject objectPool = null;
		
		for(int i = 0; i < poolObjects.pooledObjects.Count; i++){

            objectPool = poolObjects.GetPooledObject("Moeda");
            objectPool.transform.position = new Vector3(Random.Range(-1, 2), objectPool.transform.position.y, posZ-1);

            if(Random.Range(0, 2) == 1){
                objectPool.SetActive(true);
            }
            posZ--;
        }

		Debug.Log("Moedas distribuidas");
	}
}
