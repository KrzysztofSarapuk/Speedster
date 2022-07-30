using UnityEngine;

public class woman1walk : MonoBehaviour
{
    public float speed;
    public Transform woman;
    public float startPosition;
    public float endPosition;

    void Start()
    {
        woman = GetComponent<Transform>();
    }


    void Update()
    {
        if (transform.localPosition.z > endPosition)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (transform.localPosition.z < endPosition)
        {
            transform.Translate(0, 0, startPosition - endPosition);
        }

        if (transform.localPosition.z > 640)
        {
            transform.Translate(0, 0, -1 * (startPosition - endPosition));
        }
    }
}
