using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public static int CubeCounter = 0;
    public float speed = 0.0f;
    private float Move = 0;
    Vector3 Forward;
    public static Vector3 lotation;
    [SerializeField] Text CubeText;


    private void Start()
    {
        transform.position = new Vector3 (0, 0, 0);
        CubeCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Move = -1;
        }
        else
        {
            Move = 0;
        }
        Forward = transform.forward;
        transform.position += speed * Forward * Move * Time.deltaTime;
        transform.rotation = cameracontroller.direction;

        CubeText.text = CubeCounter.ToString() + ("/8");

        if (Input.GetKeyDown(KeyCode.Q))
        {
            CubeCounter += 1;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            CubeCounter += 1;
        }
    }

}
