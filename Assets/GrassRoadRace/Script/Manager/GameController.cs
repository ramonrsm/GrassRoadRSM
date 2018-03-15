using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Transform inicioFase, finalFase;
    private MoedasManager moedasManager;

    void Start()
    {
        moedasManager = MoedasManager.instance;
        //distribuirMoedas();
    }

    public void distribuirMoedas(){
        
		List<GameObject> pooledObjects = moedasManager.GetMoedas();

        for(int i = 0; i < pooledObjects.Count; i++){

            pooledObjects[i].transform.position = new Vector3(Random.Range(-1f, 1), 1, (i+1) *-1);
            pooledObjects[i].SetActive(true);
        }

		Debug.Log("Moedas distribuidas");
	}
}
