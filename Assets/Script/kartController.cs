using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kartController : MonoBehaviour
{
    public float movingSpeed;
    public kartController kart;
    public Transform gameCamera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey ("a")) 
        {
            this.transform.RotateAround (
            this.transform.position, Vector3.up, -2);
        }
        if (Input.GetKey ("d")) 
        {
            this.transform.RotateAround (
            this.transform.position, Vector3.up, 2);
        }    
        if (Input.GetKey ("w")) 
        {
            this.GetComponent<Rigidbody>().velocity =
            this.transform.forward * movingSpeed;
        } 
        gameCamera.transform.position = new Vector3(kart.transform.position.x, 3, kart.transform.position.z);
        gameCamera.transform.LookAt(kart.transform);             
    }
}
