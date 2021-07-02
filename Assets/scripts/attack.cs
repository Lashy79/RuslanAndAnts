using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public Animator HeroAttack;
    public float Damage;
    public EdgeCollider2D egde;
    public bool IsAttack;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //HeroAttack.SetBool("attack", true);
            // HeroAttack.SetBool("AttkStayBool", true);

            HeroAttack.SetTrigger("triget");
        }
       /* if (Input.GetKeyUp(KeyCode.Mouse0))
        {          
   
            HeroAttack.SetBool("AttkStayBool", false);
        }*/
       
    }
    public void heck()
    {
        Debug.Log("cho nibud");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(IsAttack)
        {
            Debug.Log("кусь");
            var target = collision.gameObject.GetComponent<Creature>();
            //var pul = collision.gameObject.GetComponent<attack>();
            var RB = this.GetComponent<EdgeCollider2D>();
            if (target)
            {
                target.TakeDamage(Damage);
            }
        }
    }
    /*
     private void OnTriggerEnter2D(Collider2D collision)
     {
         if (HeroAttack.GetBool("attack"))
         {
         //    Damage = 10;
             var target = collision.gameObject.GetComponent<Creature>();
             //var pul = collision.gameObject.GetComponent<attack>();
             var RB = this.GetComponent<EdgeCollider2D>();
             if (target)
             {
                 target.TakeDamage(Damage); 
             }
             HeroAttack.SetBool("attack", false);
         }

     }*/
}
   