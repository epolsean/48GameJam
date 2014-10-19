using UnityEngine;
using System.Collections;

public class TestTramp : MonoBehaviour {

    public Animator TrampAnim;
    public bool isBounce = false; 

    // Use this for initialization
	void Start () {
        TrampAnim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(isBounce)
        {
            //SetBounce(true);
            TrampAnim.SetBool("CanBounce", true);
            isBounce = false;
        }
        if(!isBounce)
        {
            //SetBounce(false);
            TrampAnim.SetBool("CanBounce", false);
        }
	}

    void SetBounce(bool state)
    {
        TrampAnim.SetBool("CanBounce", state);
    }
}
