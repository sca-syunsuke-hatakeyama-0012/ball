using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Map1;
    [SerializeField] GameObject Map2;
    [SerializeField] GameObject Map3;
    GameObject ChoiceMap;
    private int [] MAP = new int[9];
    private int MapX=0,MapZ=0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 9; i++)
        {

            Debug.Log(i);

            MAP[i] = Random.Range(1, 4);
            if (MAP[i] == 1)
            {
                ChoiceMap = Map1;
            }
            else if (MAP[i] == 2)
            {
                ChoiceMap = Map2;
            }
            else
            {
                ChoiceMap = Map3;
            }


            switch (i)
            {
                case 0:
                    MapX=-50;
                    MapZ=-50;
                    break;

                case 1:
                    MapX = 0;
                    MapZ = -50;
                    break;

                case 2:
                    MapX = 50;
                    MapZ = -50;
                    break;

                case 3:
                    MapX = -50;
                    MapZ = 0;
                    break;

                case 4:
                    MapX = 0;
                    MapZ = 0;
                    break;

                case 5:
                    MapX = 50;
                    MapZ = 0;
                    break;

                case 6:
                    MapX = -50;
                    MapZ = 50;
                    break;

                case 7:
                    MapX = 0;
                    MapZ = 50;
                    break;

                case 8:
                    MapX = 50;
                    MapZ = 50;
                    break;

            }

            MapCreate(ChoiceMap, MapX, MapZ);

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MapCreate(GameObject n,float x,float z)
    {
        Instantiate(n,new Vector3(x,0.0f,z),Quaternion.identity);
    }
}

