using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float fallSpeed;
    public float lifeTime;
    private float lifeTimer;
    public float distance;
    public LayerMask whatIsSolid;
    public CoinCounter CoC;
    void Start()
    {
        lifeTimer = lifeTime;
    }
    void Update()
    {
        RaycastHit2D hitInform = Physics2D.Raycast(transform.position, -transform.up, distance, whatIsSolid);
        Debug.DrawRay(transform.position, -transform.up, Color.blue);
        if (hitInform.collider != null)
        {
            if (hitInform.collider.CompareTag("Station"))
            {
                fallSpeed = 0;
            }
        }
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);

        lifeTimer -= Time.deltaTime;

        if (lifeTimer <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Fire>())
        {
            //CoinCounter.coins += 1;
           // CheckPurchasable()
            //CoC.CoinPicker();
           Destroy(gameObject);
        }
    }
}
