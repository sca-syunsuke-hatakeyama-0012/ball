using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Text text;
    int Hour = 0;
    int Minutes = 0;
    float Second = 0;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Hour = 0;
        Minutes = 0;
        Second = 0;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Hour = (int)GameManager.timer / 3600;
        Minutes = (int)GameManager.timer / 60;
        Second = GameManager.timer - (Hour * 3600 + Minutes * 60);

        if (timer > 3)
        {
            text.text = "�E�o�܂łɂ�����������\n" + Hour + ":" + Minutes + ":" + Second.ToString("F2")+
                "\n\nEnter�L�[�Ń^�C�g���ɖ߂�";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("TitleScene");
            }
        }
        else
        {
            text.text = "";
        }
    }
}
