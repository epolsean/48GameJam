using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MovePlayer : MonoBehaviour 
{
    public Button mobileMoveUp;
    public Button mobileMoveDown;
    public Button mobileMoveLeft;
    public Button mobileMoveRight;
    public EventSystem eventSys;
    Vector3 startPos = Vector3.zero;
	// Use this for initialization
	void Start () 
    {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 newVec = transform.TransformDirection(Vector3.forward);
        if (transform.position.x < startPos.x + 3.5)
        {
            if (Input.GetAxis("Horizontal") == 1 || eventSys.currentSelectedGameObject == mobileMoveRight.gameObject)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(newVec.x, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
            }
        }
        else
        {
            GetComponent<Rigidbody>().AddForce(-20, 0, 0);
        }
        if (transform.position.x > startPos.x - 3.5)
        {
            if (Input.GetAxis("Horizontal") == -1 || eventSys.currentSelectedGameObject == mobileMoveLeft.gameObject)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(-1 * newVec.x, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
            }
        }
        else
        {
            GetComponent<Rigidbody>().AddForce(20, 0, 0);
        }
	}
}
