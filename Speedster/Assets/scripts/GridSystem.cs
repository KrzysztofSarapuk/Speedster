using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public GameObject straight;
    public GameObject crossroad;
    public int width = 140;
    public int depth = 140;

    void Start()
    {
        for (int z = 0; z < depth; z += 70)
        {
            for(int x = 0; x < width; x += 70)
            {
                Vector3 position = new Vector3(x, 0, z);
                GameObject r = Instantiate(crossroad, position, Quaternion.identity);
            }
        }
    }

}
