using UnityEngine;
using System.Collections;

public class PickupSpawnerScript : MonoBehaviour
{
    public GameObject pickup;

    float moveDir = 12f;
    bool canSpawn = true;
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y >= 11)
        {
            moveDir = -moveDir;
        }
        else if (transform.position.y <= 2)
        {
            moveDir = -moveDir;
        }
        transform.position += new Vector3(0,moveDir*Time.deltaTime,0);

        if(Random.Range(1,1000) <= 2f && canSpawn && Time.timeScale == 1)
        {
            Instantiate(pickup, transform.position, Quaternion.identity);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        string otherTag = other.gameObject.tag;
        if (otherTag == "pickup")
        {
            canSpawn = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
        string otherTag = other.gameObject.tag;
        if (otherTag == "pickup")
        {
            canSpawn = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "pickup")
        {
            canSpawn = true;
        }
    }
}
