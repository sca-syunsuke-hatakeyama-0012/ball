using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public static Vector3 lotation;
    private int LotationSpeed=100;

    public static Quaternion direction;

    // Start is called before the first frame update
    void Start()
    {
        offset=transform.position-player.transform.position;
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=player.transform.position+offset;
        var lotaHorizontal = Input.GetAxis("Horizontal");
        lotation = new Vector3(0, lotaHorizontal, 0);
        transform.Rotate(lotation * LotationSpeed * Time.deltaTime);
        direction = transform.rotation;
    }
}
