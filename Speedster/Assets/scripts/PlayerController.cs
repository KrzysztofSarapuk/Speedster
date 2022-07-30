using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Text uiPenaltyPoints;
    public float score = 0;
    private bool collided;
    // Start is called before the first frame update
    void Start()
    {
        uiPenaltyPoints = GameObject.Find("penalty").GetComponent<Text>();
    }

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); // move forward
        // turning
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if (collided == true)
        {
            score += Time.deltaTime;
            uiPenaltyPoints.text = "penalty points: " + score.ToString("F2");
            print("grass");
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "grass")
        {
            collided = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "grass")
        {
            collided = false;
        }
    }
}
