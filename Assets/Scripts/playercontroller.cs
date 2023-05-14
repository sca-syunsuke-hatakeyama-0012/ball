using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public int CubeCounter = 0;
    public float speed = 0.0f;
    private float Move = 0;
    private int LotationSpeed = 100;
    Vector3 Forward;
    [SerializeField] Text CubeText;

    private Rigidbody rb; 

    void Start()
    {
        //rb= GetComponent<Rigidbody>();
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
        transform.position += speed*Forward * Move * Time.deltaTime;

        var lotaHorizontal = Input.GetAxis("Horizontal");
        var lotation = new Vector3(0, lotaHorizontal, 0);
        transform.Rotate(lotation * LotationSpeed * Time.deltaTime);

        CubeText.text = CubeCounter.ToString() + ("/9");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            CubeCounter += 1;
        }
    }

    //void SetCountText()
    //{
    //    scoretext.text="count:"+score.ToString();

    //    if (score >= 5)
    //    {
    //        wintext.text="You Win!";


    //    }
    //}
}
