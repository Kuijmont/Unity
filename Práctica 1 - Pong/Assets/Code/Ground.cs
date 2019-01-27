using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    public Lives live;
    public AudioSource point;

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "bola")
        {
            point.Play();
            live.subtractLives();
        }
    }
}
