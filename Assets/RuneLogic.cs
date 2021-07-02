using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RuneLogic : MonoBehaviour
{
    public Text Name;
    public Color rgb;
   public DoPoisonBall on;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
             
        var target = collision.gameObject.GetComponent<PlayerControl>();
        if(target!=null)
        {       
            Name.text = "POISON RUNE TAKE[F]";
        }
       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.F))
        {
            on.enabled = true;
             Destroy(this.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Name.text = "";
    }
}
