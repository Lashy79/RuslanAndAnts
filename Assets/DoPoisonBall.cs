using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoPoisonBall : MonoBehaviour
{
  
    public ParticleSystem Ball;
    public Transform BallPos;
    public DoPoisonBall script;
    public Image CoolDownImage;
    public float CoolDownTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(Ball, BallPos.position, Ball.transform.rotation);
            StartCoroutine(Cooldown());
        }
        if (script.enabled == false)
        {
            StartCoroutine(CoolDownPoison(CoolDownTime));
        }
    }
    private IEnumerator Cooldown()
    {
        script.enabled = false;
       // CoolDownImage.fillAmount = CoolDownTime / 100f;
        //for (float i = CoolDownTime/100;i<CoolDownTime;i++)
        //{
        //    CoolDownImage.fillAmount = i;
        //}
        yield return new WaitForSeconds(CoolDownTime);
        script.enabled = true;
    }
    private IEnumerator CoolDownPoison(float _time)
    {
        Debug.Log("start");
        while (_time >= 0)
        {
            CoolDownImage.fillAmount += 0.1f;
            _time -= 0.1f;
            Debug.Log("+1Tick");
            yield return new WaitForSeconds(0.1f);
            CoolDownImage.fillAmount = 0;
        }
    }
}
