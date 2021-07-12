using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pathfinding;
public class AIEnemy : Creature
{  
    public AIPath aiPath;
    public AIDestinationSetter AIDest;

    public Transform BombPos;

    public BombLogic Bomb;

    public Image HPBarPrefab;
    private Image bar;
    private Transform BarSlot;

    [SerializeField] private float speed;
    [SerializeField] private Transform lerpPos;
  

    private float AxisXEn;
    private float AxisYEn;
    public Animator Anim;
    public SpriteRenderer sprite;

    private Vector3 RightOrintation;
    private Vector3 LeftOrintation;

    private Rigidbody2D rb;


    private void Start()
    {
        LeftOrintation = new Vector3 (0, 180);
        RightOrintation = Vector3.zero;
       bar = Instantiate(HPBarPrefab, MainCanvas.CurentCanvas.transform);
       BarSlot = bar.transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(transform.right);
         bar.fillAmount = HP;

         BarSlot.transform.position = Vector3.Lerp(BarSlot.transform.position, lerpPos.position, speed) ;
        BarSlot.transform.position = RectTransformUtility.WorldToScreenPoint(Camera.main, lerpPos.position);

        if (PlayerControl.player)
        {
            AIDest.target = PlayerControl.player.transform;
        }
        Vector3 direction = Vector3.zero;
        direction = Vector3.Normalize(PlayerControl.player.transform.position - transform.position) ;
        /////              X
        if (direction.x <0)
        {
            // sprite.flipX = true;
            transform.eulerAngles = LeftOrintation;
            Anim.SetBool("TurnBool", true);
        }
       
        if (direction.x > 0)
        {
            // sprite.flipX = false;
            transform.eulerAngles = RightOrintation;
            Anim.SetBool("TurnBool", true);
        }

        /////               Y
        //if (direction.y < 0)
        //{
        //    sprite.flipX = true;

        //    Anim.SetBool("TurnBool", true);
        //}
        //else
        //{
        //    Anim.SetBool("TurnBool", false);
        //}
        //if (direction.y > 0)
        //{
        //    sprite.flipX = false;

        //    Anim.SetBool("TurnBool", true);
        //}
        //else
        //{
        //    Anim.SetBool("TurnBool", false);
        //}
        //if (AxisYEn != 0)
        //{
        //    Anim.SetBool("YBool", true);
        //}
        //else
        //{
        //    Anim.SetBool("YBool", false);
        //}

        //if (AxisXEn != 0)
        //{
        //    Anim.SetBool("TurnBool", true);
        //}
        //else
        //{
        //    Anim.SetBool("TurnBool", false);
        //}
        //if (aiPath.desiredVelocity.x >= 0.01f)
        //{
        //    transform.localScale = new Vector3(-1f, 1f, 1f);
        //}
        //else if (aiPath.desiredVelocity.x <= -0.01f)
        //{
        //    transform.localScale = new Vector3(1f, 1f, 1f);
        //}
    }
    public override void TakeDamage(float _damage)
    {
        base.TakeDamage(_damage);
    }

    public override void Die()
    {
        Instantiate(Bomb, this.transform.position, Quaternion.identity);
        PlayerControl.player.RemoveEnemyOnDie(this);
        base.Die();
       
        Destroy(bar.gameObject);
    }
 
}
