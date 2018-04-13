using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    HudManagerScript hudManagerScript;
    public static GameController instance;

    public int opcoesPaninel = 0;

    void Awake()
    {
        instance = this;
    }

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

    public bool PausarJogo(){
        Time.timeScale = (Time.timeScale == 1) ? 0 : 1;
        return true;
    }

    public int ReiniciarJogo(){
        opcoesPaninel = 1;
        return opcoesPaninel;
    }

    public void SairJogo(){
        Application.Quit();
    }
}
