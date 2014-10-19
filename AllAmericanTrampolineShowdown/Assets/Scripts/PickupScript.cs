using UnityEngine;
using System.Collections;

public class PickupScript : MonoBehaviour
{
    float lifeTime;

	// Use this for initialization
	void Start () {
        lifeTime = Time.time+3;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, 40*Time.deltaTime, Space.Self);
        if (Time.time >= lifeTime)
        {
            Destroy(this.gameObject);
        }
	}
}
