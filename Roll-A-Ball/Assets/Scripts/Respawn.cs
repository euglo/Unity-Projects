using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {


    public Transform playerTransform;
    private Vector3 startPosition;

    // Use this for initialization
    void Start()
    {
        startPosition = playerTransform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.transform.position = startPosition;
            rb.angularVelocity = Vector3.zero;
        }
    }

}
