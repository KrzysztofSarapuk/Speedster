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
    public GameObject yellowCar; public GameObject blueCar; public GameObject orangeCar; public GameObject Car;
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

                int randomCar1 = Random.Range(1, 4);
                
                if (randomCar1 == 1)
                {
                    Car = yellowCar;
                }

                int randomYellowPosition = Random.Range(10, 20);
                Vector3 YellowCarPosition = new Vector3(x + 5, 1, z + randomYellowPosition);
                GameObject instatedYellowCar = Instantiate(Car, YellowCarPosition, Quaternion.identity);


                if (randomCar1 == 2)
                {
                    Car = blueCar;
                }

                int randomBluePosition = Random.Range(25, 35);
                Vector3 BlueCarPosition = new Vector3(x + 5, 1, z + randomBluePosition);
                GameObject instatedBlueCar = Instantiate(Car, BlueCarPosition, Quaternion.identity);

                if (randomCar1 == 3)
                {
                    Car = orangeCar;
                }

                int randomOrangePosition = Random.Range(40, 55);
                Vector3 OrangeCarPosition = new Vector3(x + 5, 1, z + randomOrangePosition);
                GameObject instatedOrangeCar = Instantiate(Car, OrangeCarPosition, Quaternion.identity);




                // trees x = right, z = forward position ( between 16-50) Random.Range(12, 50)
                //Vector3 treePosition02 = new Vector3(x + 12, 0, z + Random.Range(12, 50))

                int randomtree = Random.Range(12, 50); // random tree position

                int randomHouse = Random.Range(1, 4); //instation choose from random houses: Home1, Home2, or Home3
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
                GameObject tree01L = Instantiate(tree01, tree01PositionLeft, Quaternion.identity);

                Vector3 tree02PositionRight = new Vector3(x + 12, 0, z + randomtree + 10);
                GameObject tree02R = Instantiate(tree02, tree02PositionRight, Quaternion.identity);

                Vector3 tree02PositionLeft = new Vector3(x - 12, 0, z + randomtree + 10);
                GameObject tree02L = Instantiate(tree02, tree02PositionLeft, Quaternion.identity);
            }
        }
    }


}
