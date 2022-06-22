using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowCarMoving : MonoBehaviour {
    // Start is called before the first frame update

    public float speed;
    public Transform yellowCar;
    public float startPosition;
    public float endPosition;
    //private NPC controller;

    void Start () {
        yellowCar = GetComponent<Transform> ();
    }


    void Update() {
        if (transform.localPosition.z < startPosition) {
            transform.Translate(0, 0, speed * Time.deltaTime * -1);
            if (transform.localPosition.z < endPosition) {
                transform.Translate(0, 0, (startPosition - endPosition));
            }
        }
        if (transform.localPosition.z > 630)
        {
            transform.Translate(0,0, -1);
        }
        }

    }
