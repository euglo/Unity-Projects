using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    private Text m_text;
    private GameObject[] pickups;
    public int current;
    public int total;

	// Use this for initialization
	void Start () {
        m_text = GetComponent<Text>();
        pickups = GameObject.FindGameObjectsWithTag("Pickup");
        total = pickups.Length;
    }
	
    void changeText (string text)
    {
        m_text.text = text;
    }
	// Update is called once per frame

	void Update () {
        if (current == total)
            changeText("You Won!");
        else
            changeText("Pickups Collected: " + current.ToString() + '/' + total.ToString());
    }
}
