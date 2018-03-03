using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	public float speedRotation = -140f;
	public float tempoParaMudar = 1;

	private Material materialObejct;
	public Color[] cores = new Color[2];
	public Color novaCor;
	private float cronometro;
	void Start()
	{
		materialObejct = GetComponent<MeshRenderer>().material;
		materialObejct.color = cores[0];
		novaCor = cores[1];
	}

	void Update () {

		cronometro += Time.deltaTime;

		materialObejct.color = Color.Lerp(materialObejct.color, novaCor, tempoParaMudar * Time.deltaTime);

		if(cronometro > tempoParaMudar){
			cronometro = 0;
			novaCor = cores[Random.Range(0, cores.Length)];
		}

		transform.Rotate((new Vector3(1,1,0) * speedRotation) * Time.deltaTime, Space.Self);
	}

	void OnTriggerEnter(Collider other)
	{
		switch(other.tag){

			case "Player":
			gameObject.SetActive(false); 
			break;
		}
	}
}
