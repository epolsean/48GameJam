using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour 
{
    private Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () 
    {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 newVec = transform.TransformDirection(Vector3.forward);

        if (Input.GetAxis("Horizontal") == 1)
        {
            //GetComponent<Rigidbody>().AddForce(5*Vector3.forward);
            GetComponent<Rigidbody>().velocity = new Vector3(newVec.x, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        }
        if (Input.GetAxis("Horizontal") == -1)
        {
            //GetComponent<Rigidbody>().AddForce(-5 * Vector3.forward);

            GetComponent<Rigidbody>().velocity = new Vector3(-1 * newVec.x, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        }
        if (Input.GetAxis("Vertical") == 1)
        {
            Debug.Log("Jump higher");
            //GetComponent<Rigidbody>().AddForce(-2*GetComponent<Rigidbody>().mass * Vector3.up);
        }
        if (Input.GetAxis("Vertical") == -1)
        {
            //GetComponent<Rigidbody>().AddForce(2* GetComponent<Rigidbody>().mass * Vector3.up);
        }
	}
}
