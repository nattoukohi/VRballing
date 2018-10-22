using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour {
    private SteamVR_TrackedObject trackedObj;

    public GameObject Object;

    public Transform Objecttrans;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        //Debug.Log("eee");
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip)){
            GameObject obj = Instantiate(Object, Objecttrans.transform.position, Objecttrans.rotation) as GameObject;
        }	
	}
}
