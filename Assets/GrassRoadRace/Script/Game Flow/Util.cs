using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour {

	public void Resetarprogresso(){
		PlayerPrefs.DeleteAll();
	}
}
