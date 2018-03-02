using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	public float speedRotation = -140f;
	public float speedChangeColor = 1;

	private Material materialObejct;
	public Color corAtual = Color.blue;
	private Color novaCor = Color.red;
	//private Color corRandom;
	private float cronometro;
	void Start()
	{
		materialObejct = GetComponent<MeshRenderer>().material;
		materialObejct.color = corAtual;
		//corRandom = new Color(Random.Range(0f, 1f),Random.Range(0f, 1f),Random.Range(0f, 1f),1);
	}

	void Update () {

		transform.Rotate((new Vector3(1,1,0) * speedRotation) * Time.deltaTime, Space.Self);

		//materialObejct.color = Color.Lerp(materialObejct.color, corRandom, speedChangeColor * Time.deltaTime);;
		materialObejct.color = Color.Lerp(corAtual, novaCor, speedChangeColor * Time.deltaTime);;

		cronometro += Time.deltaTime;
		
		if(cronometro > speedChangeColor){
			cronometro = 0;
			//corRandom = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f), 1);
			novaCor = Color.blue;
		}
	}
}
