using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {

    public GameObject step1;
    public GameObject step1_5;
    public GameObject step2;
    public GameObject step3;
    public GameObject step4;
    public GameObject step5;
    public GameObject step6;
    public GameObject step7;

    public GameObject player1;

    public Animator instructAnim;

    bool playAnim = true;

    int curStep = 1;
    float stepTimer = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (curStep == 1)
        {
            step1.SetActive(true);
        }
        if (curStep == 2)
        {
            step1_5.SetActive(false);
            step2.SetActive(true);
        }
        if (curStep == 3)
        {
            step2.SetActive(false);
            step3.SetActive(true);
        }
        if (curStep == 4)
        {
            step3.SetActive(false);
            step4.SetActive(true);
        }
        if (curStep == 5)
        {
            step4.SetActive(false);
            step5.SetActive(true);
        }
        if (curStep == 6)
        {
            step5.SetActive(false);
            step6.SetActive(true);
        }
        if (curStep == 7)
        {
            step6.SetActive(false);
            step7.SetActive(true);
        }
        if (curStep == 10)
        {
            step1.SetActive(false);
            step1_5.SetActive(true);
        }
        if (stepTimer < 0 && (curStep<7 || curStep==10))
        {
            if (curStep == 1)
            {
                curStep = 10;
            }
            else if (curStep == 10)
            {
                curStep = 2;
            }
            else
            {
                curStep++;
            }
            stepTimer = 5f;
            playAnim = true;
        }

        stepTimer -= Time.deltaTime;
	}
}
