using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Creature : MonoBehaviour
{
    public float HP;
   


    private void Start()
    {
       
    }
    public virtual void TakeDamage(float _damage)
    {
        HP -= _damage;
        if (HP <= 0)
        {
            Die();
        }
    }

    public virtual object RespawnData { get; set; }
    private void Update()
    {

    }
    public virtual void Die()
    {
       
        Destroy(gameObject);
    }
}

