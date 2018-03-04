using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedasManager : MonoBehaviour {

	public static MoedasManager instance;
	private PoolObjects poolObjects;

	private HudManagerScript hudManager;

	public int moedas;
	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		hudManager = HudManagerScript.instance;
		poolObjects = PoolObjects.instance;
		distribuirMoedas();
		AdicionarMoeda(PlayerPrefs.GetInt("Moedas"));
	}

	public void distribuirMoedas(){

		int posZ = 0;

		GameObject objectPool = null;
		
		for(int i = 0; i < poolObjects.pooledMoedasObjects.Count; i++){

            objectPool = poolObjects.GetPooledObject("Moeda");
            objectPool.transform.position = new Vector3(Random.Range(-1, 2), objectPool.transform.position.y, posZ-1);

            if(Random.Range(0, 2) == 1){
                objectPool.SetActive(true);
            }
            posZ--;
        }

		Debug.Log("Moedas distribuidas");
	}

	public void AdicionarMoeda(int coletavel){
		PlayerPrefs.SetInt("Moedas", moedas);
		moedas+=coletavel;
		hudManager.AtualizarColetavel(moedas);
	}
}
