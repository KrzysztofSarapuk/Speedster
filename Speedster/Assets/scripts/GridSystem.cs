using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public GameObject straight;
    public GameObject crossroad;
    public GameObject tree01;
    public GameObject tree02;
    public int width = 140;
    public int depth = 140;

    void Start()
    {

        for (int z = 0; z < depth; z += 70)
        {

            for (int x = 0; x < width; x += 70)
            {
                //base
                Vector3 position = new Vector3(x, 0, z);
                GameObject instatedCrossroad = Instantiate(crossroad, position, Quaternion.identity);

                // trees x = right, z = forward position ( between 16-50) Random.Range(12, 50)
                //Vector3 treePosition02 = new Vector3(x + 12, 0, z + Random.Range(12, 50))
                int randomtree = Random.Range(12, 50);
                
                Vector3 tree01PositionRight = new Vector3(x + 12, 0, z + randomtree);
                GameObject tree01R = Instantiate(tree01, tree01PositionRight, Quaternion.identity);

                Vector3 tree01PositionLeft = new Vector3(x - 12, 0, z + randomtree);
                GameObject tree02L = Instantiate(tree01, tree01PositionLeft, Quaternion.identity);

                Vector3 tree02PositionRight = new Vector3(x + 12, 0, z + randomtree + 10);
                GameObject tree02R = Instantiate(tree02, tree02PositionRight, Quaternion.identity);
            }
        }
    }


}
