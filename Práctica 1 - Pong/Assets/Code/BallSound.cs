using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour {

	public AudioSource bounce;

	void OnCollisionEnter(Collision otor){

        bounce.Play();
	}
}
