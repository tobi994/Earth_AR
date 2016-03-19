using UnityEngine;
using System.Collections;

public class Mars : MonoBehaviour {
    public Transform EarthTranform;

    public float moonRotY = 0;

    public float radY = 0, radZ = -0.3f;

    public float moonDist = 70;

    public float earthRadius = 25;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        moonRotY += 0.005f;
        radY += 0.03f;
        radZ += 0.0005f;

        //float x = moonDist * Math.cos(radZ) * Math.sin(radY);
        //float y = moonDist * Math.sin(radZ) * Math.sin(radY);
        //z = moonDist * Math.cos(radY);
        float x = moonDist*Mathf.Cos(radZ) * Mathf.Sin(radY);

        float y = moonDist * Mathf.Sin(radZ) * Mathf.Sin(radY);

        float z = moonDist * Mathf.Cos(radY);

        transform.position = new Vector3(EarthTranform.position.x + x, EarthTranform.position.y + y, z);
	}
}
