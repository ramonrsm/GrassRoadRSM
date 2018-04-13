using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController instance;

    void Awake()
    {
        instance = this;
    }

    public bool Morreu(Transform target, Transform limite){

        return target.transform.position.y <= limite.position.y;
	}

    public void PausarJogo(){
        Time.timeScale = (Time.timeScale == 1) ? 0 : 1;
    }
}
