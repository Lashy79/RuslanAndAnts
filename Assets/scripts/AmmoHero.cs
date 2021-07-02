using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoHero : MonoBehaviour
{
    public ParticleSystem boom;
    public GameObject oskolki;
    public float remain;
    public float timerBase;
    public bool IsParent;
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        IsParent = false;
        remain = timerBase;



    }
    void Update()
    {
        if (remain < 0)
        {
            Babah();

        }
        else
        {
            remain -= Time.deltaTime;

        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Babah();
    }

    private void Babah()
    {
        if (IsParent)
        {
            /*  for (int i = 0; i < 100; i++)
              {
                  var temp = GameObject.Instantiate(oskolki, this.transform.position, new Quaternion());
                  var RB = temp.GetComponent<Rigidbody>();
                  if (RB != null)
                  {
                      Vector3 randomDirection = new Vector3();
                      randomDirection.y = Random.Range(0, 1);
                      randomDirection.x = Random.Range(0, 1);
                      randomDirection.z = Random.Range(0, 1);
                      RB.AddForce(randomDirection * 300, ForceMode.Impulse);
                  }
              }*/
        }

        GameObject.Destroy(this.gameObject);

    }
}