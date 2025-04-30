// 투사체(밤송이) 를 발사하고, 충돌 시 물리 멈춤 + 이펙트 재생 기능을 수행하는 스크립트
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
        GetComponent<ParticleSystem>().Play();
    }

    void Start()
    {
        Shoot(new Vector3(0, 200, 2000));
    }
}
