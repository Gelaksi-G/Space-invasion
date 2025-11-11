using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject smoke_effect;
    public Transform smoke_effect_tr;
    public Transform shotPoint;
    public Transform parent;
    private float timeBtwShot;
    public float startTimeBtwShot;
    private Animator anim;
    private bool isPressed;
    public ShopMenager shopMenager;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (timeBtwShot <= 0)
        {
            if (isPressed)
            {
                anim.SetBool("isShooting", true);
                Instantiate(smoke_effect, shotPoint.position, smoke_effect_tr.rotation);
                Instantiate(bullet, shotPoint.position, transform.rotation).transform.SetParent(parent);
                timeBtwShot = startTimeBtwShot;
            }

        }
        else
        {
            timeBtwShot -= Time.deltaTime;
            anim.SetBool("isShooting", false);
        }
    }
    public void FirePressed()
    {
        isPressed = true;
    }
    public void FireNotPressed()
    {
        isPressed = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Coin>())
        {
            CoinCounter.coins += 1;
            shopMenager.CheckPurchasable();
            Debug.Log("Íÿì");
        }
    }
    public void ReloadUp()
    {
        startTimeBtwShot -= 0.05f;
    }
}
