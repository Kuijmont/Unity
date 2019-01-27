using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {
	public float velocidadInicial=300f;
	public Rigidbody rig;
	public Transform barra;
	bool inGame;
	public ElementoInteractivo start;
	private static float posX;
	private static float posY;
	private static Vector3 initPosition;
	// Use this for initialization
	void Start () {
		posX = transform.position.x;
		posY = transform.position.y;
		initPosition = new Vector3 (posX,posY);

	}
	
	// Update is called once per frame
	void Update () {
		if(!inGame){
			if (Input.GetKeyDown ("left ctrl") || start.pulsed) {
				inGame = true;
				transform.SetParent (null);
				rig.isKinematic = false;
				rig.AddForce (new Vector3 (-velocidadInicial, velocidadInicial));
			}
		}
}
	public void Reset(){
		
		transform.position = new Vector3(initPosition.x,initPosition.y);
		transform.SetParent (barra);
		inGame = false;
		rig.isKinematic = true;
		rig.AddForce (Vector3.zero);
	}
}
