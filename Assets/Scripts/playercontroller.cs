using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public int c = 0;
    public float speed =20.0f;
    public Text scoretext;
    public Text wintext;

    private Rigidbody rb; 
    private int score=0;

    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var moveHorizontal=Input .GetAxis("Horizontal");
        var moveVertical=Input .GetAxis("Vertical");

        var movement=new Vector3(moveHorizontal,0,moveVertical);

        rb.AddForce(movement*speed*Time.deltaTime);

        //if (score>=5)
        //{
        //    c += 1;
        //    if(c % 30 == 0)
        //    {

        //        wintext.text += "!";
        //    }
        //}
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("pickup"))
    //    {
    //        other.gameObject.SetActive(false);

    //        score=score+1;

    //        SetCountText();
    //    }
    //}

    //void SetCountText()
    //{
    //    scoretext.text="count:"+score.ToString();

    //    if (score >= 5)
    //    {
    //        wintext.text="You Win!";
            
           
    //    }
    //}
}
