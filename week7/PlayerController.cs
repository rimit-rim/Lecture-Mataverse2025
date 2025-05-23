// 점프 기능에 좌우 이동 기능
// 움직이는 방향에 따라 이미지 반전
// 플레이어 속도에 맞춰 애니메이션 속도 변화
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene을 사용하는데 필요하다

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;	// 물리 연산에 사용하는 컴포넌트
    Animator animator;		// 애니메이션
    float jumpForce = 680.0f;	// 점프할 때 위로 가하는 힘
    float walkForce = 30.0f;	// 좌우 이동 시 힘
    float maxWalkSpeed = 2.0f;	// 플레이어의 최고 이동 속도 제한

    void Start()
    {
        // Rigidbody2D와 Animator를 초기화
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
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
        // 움직이는 방향에 따라 반전한다
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        // 플레이어 속도에 맞춰 애니메이션 속도를 바꾼다 
        this.animator.speed = speedx / 2.0f;
    }
    // 골 도착
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("골");
        SceneManager.LoadScene("ClearScene");   // 씬 전환
    }
}