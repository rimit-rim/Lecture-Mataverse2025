// HP �������� �����ϴ� ��Ʈ�ѷ���, ���� �� �÷��̾ �������� �Ծ��� �� HP�� 10% ���ҽ�Ű�� ����
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI�� ����ϹǷ� ���� �ʰ� �߰��Ѵ�

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;	// 10% ����
    }
}
