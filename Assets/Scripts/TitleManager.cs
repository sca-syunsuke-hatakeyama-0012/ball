using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{

    [SerializeField] Text text;
    [SerializeField] Camera Maincamera;
    Vector3 posision;

    bool PuhsPflag;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "press [P] to Start";
        PuhsPflag = false;
        posision.x = 600.75f;
        posision.y = -150.0f + 246.75f;

    }

    // Update is called once per frame
    void Update()
    {
        text.transform.position = posision;

        Color color = Maincamera.backgroundColor;
        if (Input.GetKeyDown(KeyCode.P))
        {
            PuhsPflag = true;
        }

        if (PuhsPflag)
        {
            posision.y = -10.0f + 246.75f;
            color.r -= Time.deltaTime/3;
            color.g -= Time.deltaTime/3;
            color.b -= Time.deltaTime/3;
            Maincamera.backgroundColor = color;
            if (color.b<= 0.0f)
            {
                text.text = "貴方は迷宮に迷い込みました。" +
                    "\n迷宮に散らばる8つのキューブを集め、脱出しましょう。" +
                    "\n\n迷宮は入る度に姿を変え、" +
                    "\n貴方を混乱へ陥れます…。" +
                    "\n\nEnterキーで進む";
            }
            else
            {
                text.text = "";
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("SampleScene");
            }

        }
        else
        {
            color.r = 0.4f;
            color.g = 0.65f;
            color.b = 0.75f;
            Maincamera.backgroundColor = color;
        }

    }
}
