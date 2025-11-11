using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float movementSpeed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;
    private float flyTimer;
    public GameObject coin;
    private Transform coinParent;
    public Transform enemy;
    public GameObject exsplosion_effect;

    private Material matBlink;
    private Material matDefault;
    private SpriteRenderer spriteRend;

    private void Start()
    {
        coinParent = enemy.transform.parent;
        flyTimer = lifeTime;

        spriteRend = GetComponentInChildren<SpriteRenderer>();
        matBlink = Resources.Load("EnemyBlink", typeof(Material)) as Material;
        matDefault = spriteRend.material;
    }
    private void Update()
    {

        if (health <= 0)
        {
            KillsCounter.kills += 1;
            CoinDrop();
            Instantiate(exsplosion_effect, transform.position, transform.rotation).transform.SetParent(coinParent);
            Destroy(gameObject);
        }

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, -transform.up, distance, whatIsSolid);
        Debug.DrawRay(transform.position, -transform.up, Color.red);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Station"))
            {
                hitInfo.collider.GetComponent<StationController>().TakeDamage(damage);
            }
            Destroy(gameObject);
        }

        transform.Translate(Vector2.down * movementSpeed * Time.deltaTime);

        flyTimer -= Time.deltaTime;

        if (flyTimer <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        spriteRend.material = matBlink;
        Invoke(nameof(ResetMaterial), 0.5f);
    }
    void ResetMaterial()
    {
        spriteRend.material = matDefault;
    }
    public void CoinDrop()
    {
        Instantiate(coin, transform.position, transform.rotation, coinParent);
    }
}
