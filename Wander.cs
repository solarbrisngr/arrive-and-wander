using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

    public Vector3 directionPoint;

    public void GetDirection()
    {
        directionPoint = Random.insideUnitSphere * 15f;
        transform.LookAt(directionPoint);
    }

	// Use this for initialization
	void Start () {
        GetDirection();
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += this.transform.TransformDirection(Vector3.forward) * Time.deltaTime;
	}
}
