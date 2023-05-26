using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Image image;

    [SerializeField] GameObject Map1;
    [SerializeField] GameObject Map2;
    [SerializeField] GameObject Map3;

    GameObject ChoiceMap;
    private int [] MAP = new int[9];
    private int MapX=0,MapZ=0;

    public static float timer = 0;

    void MapCreate(GameObject n, float x, float z)
    {
        Instantiate(n, new Vector3(x, 0.0f, z), Quaternion.identity);
    }
    //Start is called before the first frame update
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
                    MapX = -50;
                    MapZ = -50;
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

                //case 4:中央マップをStartMapで固定したため削除
                //    MapX = 0;
                //    MapZ = 0;
                //    break;

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
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        Color color = image.color;

        if (playercontroller.CubeCounter == 8)
        {
            color.r = 1;
            color.g = 1;
            color.b = 1;
            color.a += Time.deltaTime;
            if (color.a >= 1.0)
            {
                SceneManager.LoadScene("ResultScene");
            }
        }//フェードアウト
        else
        {
            color.r = 0;
            color.g = 0;
            color.b = 0;
            if (color.a > 0)
            {
                color.a -= Time.deltaTime;
            }
        }//フェードイン
        image.color = color;
    }

}

