using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Text uiPenaltyPoints; public Text uiGlobalPoints; public Text capturedFlags;
    public float score = 0; public float globalScore = 0; public float timeScore = 0; public float result = 0;
    private bool collided; public int flags = 0;
    // Start is called before the first frame update
    void Start()
    {
        uiPenaltyPoints = GameObject.Find("penalty").GetComponent<Text>();
        uiGlobalPoints = GameObject.Find("globalScore").GetComponent<Text>();
        capturedFlags = GameObject.Find("flags").GetComponent<Text>();
        uiPenaltyPoints.text = "penalty points: 0.00";
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

        timeScore += Time.deltaTime;

        if (collided == true)
        {
            score += Time.deltaTime;
            uiPenaltyPoints.text = "penalty points: " + score.ToString("F2");
        }

        result = score + timeScore;
        uiGlobalPoints.text = "Global points: " + result.ToString("F2");

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "grass")
        {
            collided = true;
        }

        if (collision.gameObject.tag == "flag")
        {
            flags = int.Parse(capturedFlags.text);
            flags++;
            capturedFlags.text =  flags.ToString();
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
