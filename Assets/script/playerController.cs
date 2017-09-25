using System.Collections;
using UnityEngine;

public class playerController : MonoBehaviour {


    private Rigidbody rb;
    public float speed;


    void Start()
    {

        //getting the componement from the game object
        rb = GetComponent<Rigidbody>();

    }


    void Update()
    {

    }



    //physics method
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertial = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertial);

        rb.AddForce(movement * speed);
    }
}
