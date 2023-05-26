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
        for (int i = 0; i < 9; i++)//�}�b�v������9��s�����[�v
        {
            MAP[i] = Random.Range(1, 4);//1�`3�̒l�𒊑I

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
            }//���I���ꂽ�l�ɑΉ�����}�b�v����

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

                //case 4:�����}�b�v��StartMap�ŌŒ肵�����ߍ폜
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

            }//���I���ꂽ�}�b�v�̔z�u
            MapCreate(ChoiceMap, MapX, MapZ);//�z�u�ǂ���ɕ\��
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
        }//�t�F�[�h�A�E�g
        else
        {
            color.r = 0;
            color.g = 0;
            color.b = 0;
            if (color.a > 0)
            {
                color.a -= Time.deltaTime;
            }
        }//�t�F�[�h�C��
        image.color = color;
    }

}

