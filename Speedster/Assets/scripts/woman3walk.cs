using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woman3walk : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public Transform woman3;
    public Transform helper3;
    public float startPosition;
    public float endPosition;
    public float xPosition;
    //private NPC controller;

    void Start()
    {
        woman3 = GetComponent<Transform>();
    }


    void Update()
    {
        //if (transform.localPosition.z < startPosition)
        {
            //transform.Translate(0, 0, speed * Time.deltaTime);
            if (transform.localPosition.z > endPosition)
            {
                transform.Translate(0, 0, speed * Time.deltaTime);
            }
            if (transform.localPosition.z < endPosition)
            {
                transform.Translate(0, 0, -640);
            }
        }
        //if (transform.position.x < xPosition) //7.9
        //{
        //    transform.Translate(-0.02f, 0, 0);
        //}

        //if (transform.position.x > xPosition + 0.2f) //8.1
        //{
        //    transform.Translate(0.02f, 0, 0);
        //}


        //if (transform.localPosition.z < -10)
        //{
        //    transform.Translate(0, 0, startPosition);


        //    if ((transform.localPosition.x != xPosition)) // 8
        //    {
        //        transform.Translate(speed * Time.deltaTime, 0, 0);
        //    }

        //}
    }
}

