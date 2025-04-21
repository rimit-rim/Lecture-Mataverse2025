// 점프 기능에 좌우 이동 기능까지 추가
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;	// 물리 연산에 사용하는 컴포넌트
    float jumpForce = 680.0f;	// 점프할 때 위로 가하는 힘
    float walkForce = 30.0f;	// 좌우 이동 시 힘
    float maxWalkSpeed = 2.0f;	// 플레이어의 최고 이동 속도 제한

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 점프한다
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // 플레이어 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // 스피드 제한
	// 현재 x축 속도가 maxWalkSpeed보다 작으면, 힘을 더해서 이동
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
    }
}
