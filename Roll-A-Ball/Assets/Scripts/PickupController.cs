using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupController : MonoBehaviour {
    public int scoreValue;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            TextController text = Object.FindObjectOfType<TextController>();
            text.current += 1;
            Destroy(this.gameObject);

        }
    }

}
