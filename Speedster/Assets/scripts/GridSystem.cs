using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public GameObject straight;
    public GameObject crossroad;
    public GameObject tree01;
    public GameObject tree02;
    public GameObject Home1;
    public GameObject Home2;
    public GameObject Home3;
    public int width = 140;
    public int depth = 140;

    void Start()
    {

        for (int z = 0; z < depth; z += 70)
        {

            for (int x = 0; x < width; x += 70)
            {
                //base
                Vector3 position = new Vector3(x, 0, z); Vector3 homeposition = new Vector3( x + 35, 0, z + 35);
                GameObject instatedCrossroad = Instantiate(crossroad, position, Quaternion.identity);

                // trees x = right, z = forward position ( between 16-50) Random.Range(12, 50)
                //Vector3 treePosition02 = new Vector3(x + 12, 0, z + Random.Range(12, 50))
                int randomtree = Random.Range(12, 50);

                int randomHouse = Random.Range(1, 4); //print(randomHouse);
                if (randomHouse == 1)
                {
                    GameObject instatedHome = Instantiate(Home1, homeposition, Quaternion.identity); print("Home1");
                }
                if (randomHouse == 2)
                {
                    GameObject instatedHome = Instantiate(Home2, homeposition, Quaternion.identity); print("Home2");
                }
                if (randomHouse == 3)
                {
                    GameObject instatedHome = Instantiate(Home3, homeposition, Quaternion.identity); print("Home3");
                }

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
