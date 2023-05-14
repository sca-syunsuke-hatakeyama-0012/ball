using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{

    [SerializeField] GameObject MAP;


    GameObject[] Cube = new GameObject[6];
    private int ChoiceNumber;
    [SerializeField] private int ChildCount;

    private void OnEnable()
    {
        int i;

        ChildCount = MAP.transform.childCount;
        ChoiceNumber = Random.Range(0, 6);

        for (i = 0; i < 6; i++)
        {
            Cube[i] = transform.GetChild(ChildCount - (i+1)).gameObject;

            if (i == ChoiceNumber)
            {
                Cube[i].SetActive(true);
            }
            else
            {
                Cube[i].SetActive(false);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

}
