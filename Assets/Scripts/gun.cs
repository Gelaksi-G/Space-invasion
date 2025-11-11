using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform shotPoint;
    public Transform st;
    private float timeBtwShot;
    public float startTimeBtwShot;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (timeBtwShot <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                anim.SetBool("isShooting", true);
                Instantiate(bullet, shotPoint.position, transform.rotation).transform.SetParent(st);
                timeBtwShot = startTimeBtwShot;
            }
           
        }
        else
        {
            timeBtwShot -= Time.deltaTime;
            anim.SetBool("isShooting", false);
        }
    }
}
//(bullet, shotPoint.position, transform.rotation);
//.transform.SetParent(st)