using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : Creature
{
    [SerializeField]private float Speed;
    private Rigidbody2D rb;
    [SerializeField] private Creature enemy;

    public Animator Anim;
    public SpriteRenderer sprite;

    private float AxisX;
    private float AxisY;
    public EdgeCollider2D edge;

    [SerializeField] protected float Damage;

    private List<AIEnemy> EnemyList;
    private List<AIEnemy> EnemyListDestroy;

    public static PlayerControl player;
    public DoPoisonBall on;

    public Image HPBarPrefab;
    private Image Bar;
    //public Image BarPos;
    public Image posHP;
    void Start()
    {
       Bar = Instantiate(HPBarPrefab, posHP.transform);
   

        player = this;
        rb = GetComponent<Rigidbody2D>();
        EnemyList = new List<AIEnemy>();
        EnemyListDestroy = new List<AIEnemy>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var target = collision.gameObject.GetComponent<AIEnemy>();
        if (target!=null)
        {
            EnemyList.Add(target);
        }

        Debug.Log("frgrtyhrRgergretrdtfgert");
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    var target = collision.gameObject.GetComponent<AIEnemy>();
        //    //var pul = collision.gameObject.GetComponent<attack>();
        //   // var RB = this.GetComponent<EdgeCollider2D>();
        //    if (target)
        //    {
        //        target.TakeDamage(Damage);
        //        Debug.Log("1234567890");
        //    }
        //}
    }
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        var target = collision.gameObject.GetComponent<AIEnemy>();
        EnemyListDestroy.Add(target);
        Debug.Log(" i exit");
    }
    
    public void RemoveEnemyOnDie(AIEnemy enemy)
    {
        // EnemyList.Remove(enemy);
        EnemyListDestroy.Add(enemy);
    }
    void Update()
    {
        foreach (var enemy in EnemyListDestroy)
        {
            EnemyList.Remove(enemy);
        }
        EnemyListDestroy.Clear();

        AxisX = Input.GetAxis("Horizontal");
        AxisY = Input.GetAxis("Vertical");
       Vector2 moveInput = new Vector2(AxisX, AxisY);
         rb.velocity = moveInput * Speed;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;

        if(AxisX <0)
        {
            transform.right = new Vector3(-1, 0);
        }
        if (AxisX > 0)
        {
            transform.right = new Vector3(1, 0);
        }

        if (AxisY != 0)
        {
            Anim.SetBool("YBool", true);
        }
        else
        {
            Anim.SetBool("YBool", false);
        }

        if (AxisX !=0)
        {
            Anim.SetBool("TurnBool", true);
        }
        else
        {
            Anim.SetBool("TurnBool", false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemy);
        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Anim.SetTrigger("Trigetint");
        }
    }
    public override void TakeDamage(float _damage)
    {
        base.TakeDamage(_damage);
    }
    public void Attack()
    {
        foreach(var enemy in EnemyList)
        {
            enemy.TakeDamage(Damage);
        }
        
    }
}
