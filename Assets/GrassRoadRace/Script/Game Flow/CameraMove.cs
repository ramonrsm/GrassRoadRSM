
using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public GameObject mainCamera;
	public GameObject Target;
	public float smoothSpeed = 4f;
	private Vector3 offset;

	void Awake()
	{
		Target = GameObject.Find("Player");

		if(Target == null){
			Debug.Log("Aviso: Adiciona target para a câmera!");
			return;
		}
	}

	// Use this for initialization
	void Start () {
		
		ChangeView01();
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetKeyDown (KeyCode.Alpha1)) {
			ChangeView01();
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			ChangeView02();
		}*/
	}

	void FixedUpdate()
	{
		Vector3 newPosition = Target.transform.position + offset;
		Vector3 smoothPosition = Vector3.Lerp(transform.position, newPosition, smoothSpeed * Time.deltaTime);
		transform.position = smoothPosition;
	}

	void ChangeView01() {
		offset = new Vector3(Target.transform.position.x, 3f, 4f);
		transform.position = offset;
		mainCamera.transform.localPosition = new Vector3 ( 0, 0, 0 );
		mainCamera.transform.localRotation = Quaternion.Euler ( 19, 180, 0 );
	}

	/*void ChangeView02() {
		offset = new Vector3(0, 1f, -6);
		transform.position = offset;
		mainCamera.transform.localPosition = new Vector3 ( -8, 2, 0);
		mainCamera.transform.localRotation = Quaternion.Euler (14, 90, 0);
	}*/
}























