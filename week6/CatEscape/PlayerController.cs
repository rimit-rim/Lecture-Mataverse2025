using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // ���� ȭ��ǥ �Է�
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0); // �������� 3 �̵�
        }

        // ������ ȭ��ǥ �Է�
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0); // ���������� 3 �̵�
        }

        // ���� ȭ��ǥ �Է�
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 3, 0); // ���� �̵� 3 �̵�
        }

        // �Ʒ��� ȭ��ǥ �Է�
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, -3, 0); // �Ʒ��� �̵� 3 �̵�
        }
    }
}