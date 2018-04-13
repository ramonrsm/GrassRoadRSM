using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController instance;

    void Awake()
    {
        instance = this;
    }

<<<<<<< HEAD
<<<<<<< HEAD
    public bool Morreu(Transform target, Transform limite){

        return target.transform.position.y <= limite.position.y;
	}
=======
    void Start()
    {
        hudManagerScript = HudManagerScript.instance;
    }

    public void ReposicionarPlayer(Transform target, Transform limite){
        if(target.transform.position.y <= limite.position.y){
			target.transform.position = new Vector3(0,0.51f,0);
			target.transform.rotation = Quaternion.Euler ( 0, 0, 0 );
		}
    }
>>>>>>> 64f406a0ac4275db5017892ab7d0db1de2b81e78
=======
    public void limitesFase(Transform target, Transform limite){
		if(target.transform.position.y <= limite.position.y){
			target.transform.position = new Vector3(0,0.51f,0);
			target.transform.rotation = Quaternion.Euler ( 0, 0, 0 );
		}
	}
>>>>>>> parent of 64f406a... Testes

    public void PausarJogo(){
        Time.timeScale = (Time.timeScale == 1) ? 0 : 1;
    }
}
