using UnityEngine;

public class woman1walk : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public Transform woman; 
    public Transform helper1; public Transform helper2; public Transform helper3;
    public float startPosition;
    public float endPosition;
    public float xPosition;
    //private NPC controller;

    void Start()
    {
        woman = GetComponent<Transform>();
    }


    void Update()
    {
        if (transform.localPosition.z < startPosition)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            if (transform.localPosition.z < endPosition)
            {
                transform.Translate(0, 0, (endPosition - startPosition));
            }
        }
        if (transform.position.x < xPosition) //7.9
        {
            transform.Translate(0.02f, 0, 0);
        }

        if (transform.position.x > xPosition + 0.2f) //8.1
        {
            transform.Translate(-0.02f, 0, 0);
        }


        if (transform.localPosition.z > 630)
        {
            transform.Translate(0, 0, -630);

            if ((transform.localPosition.x != xPosition) || (gameObject.name == "woman1")) // 8
            {
                transform.localPosition = helper1.localPosition;
            }

            if ((transform.localPosition.x != xPosition) || (gameObject.name == "woman2")) // 8
            {
                transform.localPosition = helper2.localPosition;
            }

            if ((transform.localPosition.x != xPosition) || (gameObject.name == "woman3")) // 8
            {
                transform.Translate(0, 0, speed * Time.deltaTime * -1);
            }

        }
        //if (transform.localPosition.y < 0.1f)
        //{
        //    transform.Translate(0, 0.25f, 0);
        //}
    }

    }
