using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePins : MonoBehaviour {
    private static int numpin = 10;
    public GameObject [] Object = new GameObject [numpin];

    // Use this for initialization
    void Start () {
        CreateThePins();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateThePins()
    {
        foreach(GameObject x in Object)
        {
            Instantiate(x);
        }
        
    }
}
