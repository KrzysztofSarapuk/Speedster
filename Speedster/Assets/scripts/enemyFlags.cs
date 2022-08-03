using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyFlags : MonoBehaviour
{
    public Text capturedEnemyFlags; public int enemyFlag = 0;


    // Start is called before the first frame update
    void Start()
    {
        capturedEnemyFlags = GameObject.Find("enemyFlags").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "flag")
        {
            enemyFlag = int.Parse(capturedEnemyFlags.text);
            enemyFlag++;
            capturedEnemyFlags.text = enemyFlag.ToString();
        }

    }
}
