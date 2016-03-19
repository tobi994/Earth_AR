using UnityEngine;
using System.Collections;

public class Earth : MonoBehaviour {
    public float speedRotation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(transform.rotation.x, Time.deltaTime * speedRotation,transform.rotation.z);
        if(transform.rotation.y > 360)
        {
            transform.Rotate(transform.rotation.x, 0, transform.rotation.z);
        }
	}
}
