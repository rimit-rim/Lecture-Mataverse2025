// �ڵ���(car)�� ��ǥ ����(flag)���� �󸶳� ���Ҵ����� ȭ�鿡 �ؽ�Ʈ�� �����ִ� ��ũ��Ʈ
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI�� ����ϴ� �� �ʿ��ϴ�
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject car;	// �ڵ���
    GameObject flag;	// ��ǥ����
    GameObject distance;	// ���� �Ÿ��� ǥ���� UI �ؽ�Ʈ

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        // �ڵ����� ����� x��ǥ ���̸� ����Ͽ� length�� ����
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        // length ���� �Ҽ��� ��°�ڸ����� ���� ���ڿ��� �ٲٰ� UI �ؽ�Ʈ�� ǥ��
        this.distance.GetComponent<TextMeshProUGUI>().text = "Distance: " + length.ToString("F2") + "m";
         }
    }
