using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamage : Creature
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float Damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var heroTarget = collision.gameObject.GetComponent<PlayerControl>();
        if (heroTarget != null)
        {
            heroTarget.TakeDamage(0.3f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
