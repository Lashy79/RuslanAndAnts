using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageBall : PlayerControl
{
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
            target.TakePoison(Damage, 1);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("i exit" + collision.gameObject.name);
    }
    public override void TakeDamage(float _damage)
    {
        base.TakeDamage(_damage);
    }
}