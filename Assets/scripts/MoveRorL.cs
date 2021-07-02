using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRorL : MonoBehaviour
{
    public Animator turn;
    public SpriteRenderer SpriteRen;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            turn.SetBool("TurnBool", true);
            SpriteRen.flipX = false;
            Debug.Log("eeboiu");





            // turn.SetBool("TurnBool", true);

            //    //HeroAttack.SetBool("attack", true);
            //    //HeroAttack.SetBool("AttkStayBool", true);
            //    // turn.SetBool("MoveR", false);
            //    if (SpriteRen.flipX == false)
            //    {
            //        SpriteRen.flipX = true;
            //    }
            //    else
            //    {

            //    }
            //}
            //else
            //{
            //    turn.SetBool("MoveR", false);
        //    turn.SetBool("TurnBool", falsew);
        }
     
        if (Input.GetKey(KeyCode.A))
        {
            SpriteRen.flipX = true;
            turn.SetBool("TurnBool", true);
            //    if (SpriteRen.flipX == true)
            //    {
            //        SpriteRen.flipX = false;
            //    }
            //    else
            //    {

            //    }
            //    turn.SetBool("MoveL", true);
            //    //HeroAttack.SetBool("attack", true);
            //    //HeroAttack.SetBool("AttkStayBool", true);
            //   // turn.SetBool("MoveL", false);
            //}
            //else
            //{
            //    turn.SetBool("MoveL", false);
            //}    
            turn.SetBool("TurnBool", false);
        }
        else
        {
          //  turn.SetBool("TurnBool", false);
        }
    }
}