using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverBola : MonoBehaviour
{
    int direccionX;
    int direccionY;

    float speed;

    // Puntuacion

    public Text scoreText;

    int player1Score;
    int player2Score;

    // Winner

    public Text winner;

    // Start is called before the first frame update
    void Start() {

        MoveBall();

    }

    // Update is called once per frame
    void Update() {

        scoreText.text = player1Score.ToString() + " - " + player2Score.ToString();

        if (player1Score == 2)
        {
            winner.text = "PLAYER 1 GANA";
            winner.gameObject.SetActive(true);
            ResetBall();
        }
        if (player2Score == 2)
        {
            winner.text = "PLAYER 2 GANA";
            winner.gameObject.SetActive(true);
            ResetBall();
        }

    }

    // Reset Ball
    void ResetBall(){
        transform.localPosition = new Vector3(0, 0, 0);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    // Move Ball
    void MoveBall(){
        speed = Random.Range(5, 10);

        direccionX = Random.Range(0, 2);
        if (direccionX == 0) {
            direccionX = 1;
        } else {
            direccionX = -1;
        }

        direccionY = Random.Range(0, 2);
        if (direccionY == 0){
            direccionY = 1;
        }else{
            direccionY = -1;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(speed * direccionX, speed * direccionY, 0);
    }

    // Colison con objeto
    private void OnCollisionEnter(Collision collision){

        if (collision.collider.tag == "player1goal") {
            player1Score++;
            ResetBall();
            Invoke("MoveBall", 2); // Reset game 2 seconds and then use method "MoveBall"
           
        }

        if (collision.collider.tag == "player2goal"){
            player2Score++;
            ResetBall();
            Invoke("MoveBall", 2); // Reset game 2 seconds
        }
    }
}
