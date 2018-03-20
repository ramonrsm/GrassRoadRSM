using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController instance;

    void Awake()
    {
        instance = this;
    }

    public void limitesFase(Transform target, Transform limite){
		if(target.transform.position.y <= limite.position.y){
			target.transform.position = new Vector3(0,0.51f,0);
			target.transform.rotation = Quaternion.Euler ( 0, 0, 0 );
		}
	}

    public void PausarJogo(){
        Time.timeScale = (Time.timeScale == 1) ? 0 : 1;
    }
}
