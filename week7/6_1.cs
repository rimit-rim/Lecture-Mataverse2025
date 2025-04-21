// 플레이어가 스페이스바를 누르면 점프하도록 만들어주는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 680.0f; // 점프할 때 위로 가해줄 힘의 크기

    void Start()
    {
        Application.targetFrameRate = 60;
        // 플레이어 오브젝트에 붙어 있는 Rigidbody2D 컴포넌트를 가져옴(이게 있어야 AddForce 점프 가능)
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 점프한다
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 스페이스바 누르면 transform.up 방향(= 위쪽)으로 힘을 가해 점프함
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
    }
}
