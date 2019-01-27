using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPala : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;

    float speed;
    float finalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.15f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up)){

            if (transform.localPosition.y > 3.6){
                finalSpeed = 0;
            }else{
                finalSpeed = speed;
            }

            transform.Translate(0, finalSpeed, 0);
        }
        if (Input.GetKey(down)){

            if (transform.localPosition.y < -3.6){
                finalSpeed = 0;
            }else{
                finalSpeed = speed;
            }

            transform.Translate(0, -finalSpeed, 0);
        }
    }
}
