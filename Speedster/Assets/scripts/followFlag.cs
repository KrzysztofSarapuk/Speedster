using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followFlag : MonoBehaviour
{
    public GameObject[] flags;
    int currentFlag = 0;
    public float speed = 10.0f;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {





        if (currentFlag < flags.Length -1 )
        {
            if (flags[currentFlag] != null)
            {
                if (Vector3.Distance(this.transform.position, flags[currentFlag].transform.position) < 3)
                    currentFlag++;
            }

            if (flags[currentFlag] == null)
            {
                currentFlag++;
                print("dlugosc tablicy" + flags.Length);
            }


            if (currentFlag < flags.Length)
            {
                print("Wynik:   " + currentFlag.ToString());
            }

            
            if (currentFlag < flags.Length -1 )
            {
                this.transform.LookAt(flags[currentFlag].transform);
                this.transform.Translate(0, 0, speed * Time.deltaTime);
            }

        }

    }
}
