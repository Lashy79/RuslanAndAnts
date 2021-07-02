using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBar : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]//���� ����� � ����������, �� �� ������ ������� �� �����. �������� - �����)
    private Transform LerpPos;

    [SerializeField]
    private float speed;

    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, LerpPos.position, speed);
    }
}
