using UnityEngine;
using System.Collections;

public class BurgerMenuCollisionDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.y < -500)
        {
            Destroy(this.gameObject);
        }
	
	}

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().velocity = new Vector3(0,-40,0);
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<TrailRenderer>().enabled = true;
        GetComponent<TrailRenderer>().time = 2;

        if (collision.gameObject.name == "Play")
        {
            GameObject.Find("Main Camera").GetComponent<MenuScript>().Play();
        }
        if (collision.gameObject.name == "Options")
        {
            GameObject.Find("Main Camera").GetComponent<MenuScript>().Settings();
        }
        if (collision.gameObject.name == "Credits")
        {
            GameObject.Find("Main Camera").GetComponent<MenuScript>().Credits();
        }
        if (collision.gameObject.name == "Quit")
        {
            GameObject.Find("Main Camera").GetComponent<MenuScript>().Quit();
        }
        if (collision.gameObject.name == "Back")
        {
            GameObject.Find("Main Camera").GetComponent<MenuScript>().Back();
        }
    }
}
