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


    void MapCreate(GameObject n, float x, float z)
    {
        Instantiate(n, new Vector3(x, 0.0f, z), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 9; i++)//マップ生成を9回行うループ
        {
            MAP[i] = Random.Range(1, 4);//1～3の値を抽選

            switch (MAP[i])
            {
                case 1:
                    ChoiceMap = Map1;
                    break;

                case 2:
                    ChoiceMap = Map2;
                    break;

                case 3:
                    ChoiceMap = Map3;
                    break;
            }//抽選された値に対応するマップを代入

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

            }//抽選されたマップの配置
            MapCreate(ChoiceMap, MapX, MapZ);//配置どおりに表示
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

