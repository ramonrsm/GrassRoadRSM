﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	private Vector3 vetorInicalDireita, vetorFinalDireita;
	private Vector3 vetorInicalEsquerda, vetorFinalEsquerda;
	
	public float moveSpeed = -7;
	public float forceJump = 300f;

	public bool podeMover = true;
	public bool floor;
	public LayerMask	whatIsGround;

	private float x;
	private Rigidbody rigidbodyPlayer;

	

	// Use this for initialization
	void Start () {
		rigidbodyPlayer  = GetComponent<Rigidbody>();
	}

	void Update()
	{
		// Movimentação
		x = Input.GetAxisRaw("Horizontal");

		if(Input.GetButtonDown("Jump") && floor){
			rigidbodyPlayer.AddForce(Vector3.up * forceJump);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if(podeMover){
			Move();
		}
	}

	public void Move() {

		// MOVE O PLAYER PARA FRENTE
		float moveAmount = Time.smoothDeltaTime * moveSpeed;
		transform.Translate(0f, 0f, moveAmount);

		// MOVE O PLAYER PARA OS LADOS
		rigidbodyPlayer.velocity = new Vector3(x * moveSpeed, rigidbodyPlayer.velocity.y, rigidbodyPlayer.velocity.z);

		// VERIFICA SE ESTÁ TOCANDO O CHÃO
		vetorInicalDireita = new Vector3(transform.position.x +0.5f, transform.position.y, transform.position.z);
		vetorFinalDireita = new Vector3(transform.position.x +0.5f, transform.position.y - 0.6f, transform.position.z);
		Debug.DrawLine(vetorInicalDireita, vetorFinalDireita, Color.green);

		vetorInicalEsquerda = new Vector3(transform.position.x -0.5f, transform.position.y, transform.position.z);
		vetorFinalEsquerda = new Vector3(transform.position.x -0.5f, transform.position.y - 0.6f, transform.position.z);
		Debug.DrawLine(vetorInicalEsquerda, vetorFinalEsquerda, Color.green);
		
		if(Physics.Linecast(vetorInicalDireita, vetorFinalDireita, whatIsGround) || Physics.Linecast(vetorInicalEsquerda, vetorFinalEsquerda, whatIsGround)){
			floor = true;
		}else{
			floor = false;
		}
	}
}
