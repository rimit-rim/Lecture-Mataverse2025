// ���� ��ɿ� �¿� �̵� ���
// �����̴� ���⿡ ���� �̹��� ����
// �÷��̾� �ӵ��� ���� �ִϸ��̼� �ӵ� ��ȭ
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene�� ����ϴµ� �ʿ��ϴ�

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;	// ���� ���꿡 ����ϴ� ������Ʈ
    Animator animator;		// �ִϸ��̼�
    float jumpForce = 680.0f;	// ������ �� ���� ���ϴ� ��
    float walkForce = 30.0f;	// �¿� �̵� �� ��
    float maxWalkSpeed = 2.0f;	// �÷��̾��� �ְ� �̵� �ӵ� ����

    void Start()
    {
        // Rigidbody2D�� Animator�� �ʱ�ȭ
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        // �����Ѵ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // �¿� �̵�
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // �÷��̾� �ӵ�
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // ���ǵ� ����
        // ���� x�� �ӵ��� maxWalkSpeed���� ������, ���� ���ؼ� �̵�
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
        // �����̴� ���⿡ ���� �����Ѵ�
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        // �÷��̾� �ӵ��� ���� �ִϸ��̼� �ӵ��� �ٲ۴� 
        this.animator.speed = speedx / 2.0f;
    }
    // �� ����
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("��");
        SceneManager.LoadScene("ClearScene");   // �� ��ȯ
    }
}