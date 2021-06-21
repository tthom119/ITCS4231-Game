using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : MonoBehaviour {

	public GameObject fruit;
	// Use this for initialization
	void Start () 
	{
		
	}

    // Update is called once per frame
    [System.Obsolete]
    void Update () 
	{
		fruit.transform.RotateAround(Vector3.up, Time.deltaTime);
	}
}
