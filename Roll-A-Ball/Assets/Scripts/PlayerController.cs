using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 200;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();       //gameobject refers to the thing the player is attached to
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");      //gives a ranged value of what input the player is giving
        float z = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(x, 0, z) * speed * Time.deltaTime, ForceMode.VelocityChange);  //Time.deltaTime gives time between time and most current frame, for cross platforms to run at same speed
	}
}
