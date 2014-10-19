using UnityEngine;
using System.Collections;

public class PickupSpawnerScript : MonoBehaviour
{
    public GameObject pickup;

    float moveDir = 0.2f;
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
        transform.position += new Vector3(0,moveDir,0);

        if(Random.Range(1,1000) <= 100f && canSpawn)
        {
            Instantiate(pickup, transform.position, Quaternion.identity);
        }
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "pickup")
        {
            canSpawn = false;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "pickup")
        {
            canSpawn = true;
        }
    }
}
