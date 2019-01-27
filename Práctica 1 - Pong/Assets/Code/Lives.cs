using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour{

    public static int initLives = 3;
    public Text textLives;
    public MoveBall myBall;
    public MoveShovel myShovel;
    public GameObject gameover;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        textLives.text = "Vidas: " + string.Concat(initLives);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void subtractLives()
    {
        if (initLives <= 1)
        {
            initLives = initLives - 1;
            textLives.text = "Vidas: " + string.Concat(initLives);
            gameover.SetActive(true);
            audio.Play();
            Invoke("loadPresentation", 3);
            myShovel.Reset();
            myBall.velocidadInicial = 0;
            myShovel.speed = 0;
            myBall.Reset();

        }
        else
        {
            initLives = initLives - 1;
            textLives.text = "Vidas: " + string.Concat(initLives);
            myShovel.Reset();
            myBall.Reset();
        }
    }

    public void loadPresentation()
    {
        SceneManager.LoadScene(0);
    }
}
