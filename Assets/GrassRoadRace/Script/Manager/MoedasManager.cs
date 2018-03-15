using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedasManager : MonoBehaviour {

	public static MoedasManager instance;
	private PoolObjects poolObjects;

	private HudManagerScript hudManager;

	public List<GameObject> list;

	public int moedasAtuais;
	public int moedasFase;

	public int frame;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		hudManager = HudManagerScript.instance;
		poolObjects = PoolObjects.instance;
		StartCoroutine("distribuirMoedas");		
	}

	public IEnumerator distribuirMoedas(){

        yield return new WaitUntil(() => poolObjects != null);

		list = GetMoedas();
		GameObject objectPool = null;
		int posXTemp = 0;

		for(int i = 0; i < list.Count; i++){

            if(!list[i].activeInHierarchy){
				objectPool = list[i];

				if(i <= list.Count/3){
					posXTemp = -1;
				}else if(i <= list.Count/2){
					posXTemp = 0;
				}else{
					posXTemp = 1;
				}
				
				objectPool.transform.position = new Vector3(posXTemp, 1, (i+1) *-1);
            	objectPool.SetActive(true);
			}
		}
		Debug.Log("Moedas distribuidas");
	}

	public List<GameObject> GetMoedas(){

		list = new List<GameObject>();
		GameObject objectPool = null;

		for(int i = 0; i < poolObjects.pooledObjects.Count; i++){

            if(!poolObjects.pooledObjects[i].activeInHierarchy && poolObjects.pooledObjects[i].tag == "Moeda"){
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
