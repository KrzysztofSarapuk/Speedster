using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public GameObject straight; public GameObject crossroad; public GameObject tree01;
    public GameObject tree02; public GameObject tree03; public GameObject Home1; public GameObject Home2; public GameObject Home3; public GameObject Home4;
    public GameObject yellowCar; public GameObject blueCar; public GameObject orangeCar; public GameObject Car; public GameObject straightline;
    public GameObject YellowCarMoving; public int width = 140; public int depth = 140;public int rndTree03; public int garage;public int countdown;
    public GameObject woman1Moving; public GameObject woman2Moving; public GameObject woman3Moving; public GameObject woman4Moving;
    public GameObject woman5Moving; public GameObject woman6Moving; public GameObject woman7Moving; public GameObject woman8Moving;
    public GameObject woman9Moving; public GameObject woman10Moving; public GameObject woman11Moving; public GameObject woman12Moving;

    void Start()
    {
        for (int z = 0; z < depth; z += 100)
        {
            for (int x = 0; x < width; x += 100)
            {
                //base
                countdown++;
                int straightstreet = 0;
                Vector3 position = new Vector3(x, 0, z); Vector3 homeposition = new Vector3( x + 35, 0, z + 35);
                //GameObject instatedCrossroad = Instantiate(crossroad, position, Quaternion.identity);

                straightstreet = Random.Range(1, 5); //base straight

                if (straightstreet == 1)
                {
                    GameObject instatedStraightline = Instantiate(straightline, position, Quaternion.identity);
                }

                if (straightstreet > 1 )
                {
                    GameObject instatedCrossroad = Instantiate(crossroad, position, Quaternion.identity);
                }
                straightstreet = 0;

                if ( countdown < 42 ) // Zone 1
                {
                    int YellowCarmoving = Random.Range(10, 360); //driving yellow cars
                    Vector3 YellowCarMovingPosition = new Vector3(x - 3, 0.75f, z + YellowCarmoving);
                    GameObject instatedYellowCarMoving = Instantiate(YellowCarMoving, YellowCarMovingPosition, Quaternion.identity);

                    int woman1 = Random.Range(10, 360); //woman1
                    Vector3 woma1MovingPosition = new Vector3(9, 0.25f, z + woman1);
                    GameObject instatedWoman1 = Instantiate(woman1Moving, woma1MovingPosition, Quaternion.identity);

                    int woman2 = Random.Range(10, 360); //woman2
                    Vector3 woma2MovingPosition = new Vector3(-7.5f, 0.25f, z + woman2);
                    GameObject instatedWoman2 = Instantiate(woman2Moving, woma2MovingPosition, Quaternion.identity);

                    int woman3 = Random.Range(10, 360); //woman3
                    Vector3 woma3MovingPosition = new Vector3(-9f, 0.25f, z + woman3);
                    GameObject instatedWoman3 = Instantiate(woman3Moving, woma3MovingPosition, Quaternion.Euler(0,180,0));

                    int woman4 = Random.Range(10, 360); //woman4
                    Vector3 woma4MovingPosition = new Vector3(7.5f, 0.25f, z + woman4);
                    GameObject instatedWoman4 = Instantiate(woman4Moving, woma4MovingPosition, Quaternion.Euler(0, 180, 0));

                    int woman5 = Random.Range(10, 360); //woman5
                    Vector3 woma5MovingPosition = new Vector3(109, 0.25f, z + woman5);
                    GameObject instatedWoman5 = Instantiate(woman5Moving, woma5MovingPosition, Quaternion.identity);

                    int woman6 = Random.Range(10, 360); //woman6
                    Vector3 woma6MovingPosition = new Vector3(92.5f, 0.25f, z + woman6);
                    GameObject instatedWoman6 = Instantiate(woman6Moving, woma6MovingPosition, Quaternion.identity);

                    int woman7 = Random.Range(10, 360); //woman7
                    Vector3 woma7MovingPosition = new Vector3(91f, 0.25f, z + woman7);
                    GameObject instatedWoman7 = Instantiate(woman7Moving, woma7MovingPosition, Quaternion.Euler(0, 180, 0));

                    int woman8 = Random.Range(10, 360); //woman8
                    Vector3 woma8MovingPosition = new Vector3(107.5f, 0.25f, z + woman8);
                    GameObject instatedWoman8 = Instantiate(woman8Moving, woma8MovingPosition, Quaternion.Euler(0, 180, 0));

                    int woman9 = Random.Range(10, 360); //woman9
                    Vector3 woma9MovingPosition = new Vector3(209, 0.25f, z + woman9);
                    GameObject instatedWoman9 = Instantiate(woman9Moving, woma9MovingPosition, Quaternion.identity);

                    int woman10 = Random.Range(10, 360); //woman10
                    Vector3 woma10MovingPosition = new Vector3(192.5f, 0.25f, z + woman10);
                    GameObject instatedWoman10 = Instantiate(woman10Moving, woma10MovingPosition, Quaternion.identity);

                    int woman11 = Random.Range(10, 360); //woman11
                    Vector3 woma11MovingPosition = new Vector3(191f, 0.25f, z + woman11);
                    GameObject instatedWoman11 = Instantiate(woman11Moving, woma11MovingPosition, Quaternion.Euler(0, 180, 0));

                    int woman12 = Random.Range(10, 360); //woman12
                    Vector3 woma12MovingPosition = new Vector3(207.5f, 0.25f, z + woman12);
                    GameObject instatedWoman12 = Instantiate(woman12Moving, woma12MovingPosition, Quaternion.Euler(0, 180, 0));


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
                    rndTree03 = Random.Range(20, 35);
                    Vector3 tree03PositionLeft = new Vector3(x - 12, 0, z + randomtree + rndTree03);
                    GameObject tree03L = Instantiate(tree03, tree03PositionLeft, Quaternion.identity);

                    garage = Random.Range(25, 35);
                    Vector3 rndgarage = new Vector3(x - 25, 0, z + randomtree + garage);
                    GameObject rndhomo04 = Instantiate(Home4, rndgarage, Quaternion.identity);
                }
                
            }
        }
    }
}
