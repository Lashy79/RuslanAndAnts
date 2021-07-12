using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageBall : PlayerControl
{
    [SerializeField] float Dmg;
    [SerializeField] AIEnemy En;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var target = collision.gameObject.GetComponent<AIEnemy>();
        if (target!=null)
        {
            target.TakePoison(Dmg, 1f);
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }
    public override void TakeDamage(float _damage)
    {
        base.TakeDamage(_damage);
    }
}