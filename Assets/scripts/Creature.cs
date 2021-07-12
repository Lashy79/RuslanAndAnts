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
    public void TakePoison(float _damage, float _time)
    {
        StartCoroutine(TickPoison(_damage, _time));
    }
    public float TimeTick= 0.1f;
    private IEnumerator TickPoison(float _damage, float _time)
    {
        Debug.Log("poison start");
        while (_time > 0)
        {
            _time -= TimeTick;
            Debug.Log("poison Tick");
            TakeDamage(_damage);
            yield return new WaitForSeconds(TimeTick);
        }
        Debug.Log("Tick End");
    }
}

