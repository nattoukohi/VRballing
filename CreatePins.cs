using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePins : MonoBehaviour {
    public GameObject [] Object = new GameObject [10];

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
