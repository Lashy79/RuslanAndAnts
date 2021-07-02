using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBar : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]//поле будет в инспекторе, но из класса торчать не будет. Сокрытие - добро)
    private Transform LerpPos;

    [SerializeField]
    private float speed;

    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, LerpPos.position, speed);
    }
}
