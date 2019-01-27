using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShoveLeft : MonoBehaviour {
	public float speed= 1f;
	private float posY;
	private float posX;
	static float limitBot = -0.1680691f;
	static float limitTop= 1.74f;
	private static Vector3 initPosition;
	public ElementoInteractivo botonUp;
	public ElementoInteractivo botonDown;
	// Use this for initialization
	void Start () {
		
		posY = transform.position.y;
		posX = transform.position.x;


		initPosition = new Vector3(posX,posY);

	}
	
	// Update is called once per frame
	void Update () {
		float direction;

		direction = Input.GetAxisRaw ("Vertical");
		if (botonUp.pulsed) {
			posY = posY + (1 * speed * Time.deltaTime);
		} else {
			if (botonDown.pulsed) {
				posY = posY + (-1 * speed * Time.deltaTime);
			} else {
				posY = posY+(direction * speed * Time.deltaTime);
			}
		}

		if (posY >= limitTop) {
			posY = limitTop;
			transform.position = new Vector3 (posX, posY);
		} else {
			if (posY <= limitBot) {
				posY = limitBot;
				transform.position = new Vector3 (posX, posY);
			}else{
				transform.position = new Vector3 (posX, posY);
		}
	}


}
	public void Reset(){
		
		transform.position = initPosition;

		posY = transform.position.y;
		posX = transform.position.x;
		print (initPosition);

	}
}
