using UnityEngine;
using System.Collections;

public class BurgerMenuShooter : MonoBehaviour {

    public Rigidbody datBurger;
    public int BurgerSpeed = 20;
    public bool CanFire = true;

    Vector3 direction = Vector3.zero;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray rayPos = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(rayPos, out hit, Mathf.Infinity))
        {
            Debug.DrawLine(Camera.main.transform.position, hit.point, Color.red);
            direction = Vector3.Normalize(hit.point - Camera.main.transform.position);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (CanFire)
            {
                CanFire = false;
                Rigidbody Burger = Instantiate(datBurger, this.transform.position, this.transform.rotation) as Rigidbody;
                Burger.velocity = transform.TransformDirection(direction * BurgerSpeed);
                audio.Play();
                Invoke("ResetFire", 1);
            }
        }
    }

    void ResetFire()
    {
        CanFire = true;
    }
}
