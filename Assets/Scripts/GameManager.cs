using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Map1;
    [SerializeField] GameObject Map2;
    [SerializeField] GameObject Map3;
    GameObject ChoiceMap;
    private int [] MAP;
    private int MapX=0,MapZ=0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i <= 9; i++)
        {
            MAP[i] = Random.Range(1, 4);
            if (MAP[i] == 1)
            {
                ChoiceMap=Map1;
            }
            else if (MAP[i] == 2)
            {
                ChoiceMap = Map2;
            }
            else
            {
                ChoiceMap = Map3;
            }
            MapCreate(ChoiceMap,MapX,MapZ);

        }


    }

    void MapCreate(GameObject n,float x,float z)
    {
        Instantiate(n,new Vector3(x,0.0f,z),Quaternion.identity);
    }
}

