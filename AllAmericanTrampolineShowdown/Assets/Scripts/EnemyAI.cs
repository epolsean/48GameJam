using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public GameObject thisEnemy;
    public Animator EnemyAnim;
    // Use this for initialization
	void Start () {
        GetComponentInChildren<Animation>().Play();
        GetComponentInChildren<Animation>()["CharacterFatness"].speed = 0;
        GetComponentInChildren<Animation>()["CharacterFatness"].time = 0;
        EnemyAnim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 fwd = transform.TransformDirection(Vector3.forward)*10;
        Vector3 upAngle = transform.TransformDirection(new Vector3(0, 1, 1))*10;
        Vector3 downAngle = transform.TransformDirection(new Vector3(0, -1, 1))*10; 
        Debug.DrawRay(this.transform.position, fwd, Color.red);
        Debug.DrawRay(this.transform.position, upAngle, Color.blue);
        Debug.DrawRay(this.transform.position, downAngle, Color.green);
        RaycastHit playerInfo;
        if (Physics.Raycast(transform.position, fwd, out playerInfo, 15))
        {
            if(playerInfo.collider.tag == "Player")
            {
                print("There is something in front of the object!");
                CallFire();
            }
        }
        else if (Physics.Raycast(transform.position, upAngle, out playerInfo, 15))
        {
            //print("ABOVE CHECK");
            if (playerInfo.collider.tag == "Player")
            {
                print("Player Above!");
                Invoke("CallFire", 1);
            }
        }
        else if (Physics.Raycast(transform.position, downAngle, out playerInfo, 15))
        {
            if (playerInfo.collider.tag == "Player")
            {
                print("Player Below!");
                Invoke("CallFire", 1);
            }
        }
	}

    void CallFire()
    {
        this.GetComponentInChildren<EnemyFire>().FIRE = true;
        EnemyAnim.SetTrigger("Throw");
    }
}
