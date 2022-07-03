using UnityEngine;

public class woman1walk : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public Transform woman; 
    public Transform helper1;
    public float startPosition;
    public float endPosition;
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
        if (transform.localPosition.x < 7.9)
        {
            transform.Translate(0.02f, 0, 0);
        }

        if (transform.localPosition.x > 8.1)
        {
            transform.Translate(-0.02f, 0, 0);
        }
        if (transform.localPosition.z > 630)
        {
            transform.Translate(0, 0, -630);
            
            if(transform.localPosition.x != 8)
                {
                transform.localPosition = helper1.localPosition;
                }

        }
        //if (transform.localPosition.y < 0.1f)
        //{
        //    transform.Translate(0, 0.25f, 0);
        //}
    }

    }
