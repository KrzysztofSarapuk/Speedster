using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woman3walk : MonoBehaviour
{
    public float speed;
    public Transform woman3;
    public float startPosition;
    public float endPosition;

    void Start()
    {
        woman3 = GetComponent<Transform>();
    }

    void Update()
    {     
            if (transform.localPosition.z > endPosition)
            {
                transform.Translate(0, 0, speed * Time.deltaTime);
            }
            if (transform.localPosition.z < endPosition)
            {
                transform.Translate(0, 0, -1 * (startPosition - endPosition));
            }

        if (transform.localPosition.z > startPosition)
        {
            transform.Translate(0, 0, 1);
        }
    }
}

