// 밤송이(투사체) 를 발사하고 충돌하면 멈추도록 동작
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    void Start()
    {
        Shoot(new Vector3(0, 200, 2000));
    }
}
