// ���� �ð����� ���� ��ġ���� ȭ��(Arrow)�� �����ϴ� ����
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;	// ������ ȭ�� ������
    float span = 1.0f;	// ȭ�� ���� �ֱ�
    float delta = 0;		// �帥 �ð� ���� Ÿ�̸�

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)	// 1�ʸ��� �� �� ����
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);   	// �����տ��� �� ȭ�� ����
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
