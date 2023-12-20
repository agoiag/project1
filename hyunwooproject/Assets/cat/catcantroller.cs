using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catcantroller : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // ���������� ���̸� ���Ѵ�
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺�� Ŭ���� ��ǥ
            startPos = Input.mousePosition;
            Debug.Log(startPos);

            
        }
        //���� ���콺 Ŭ��.
        else if (Input.GetMouseButtonUp(0))
        {
            // ���콺�� ������ �� ��ǥ
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;

            // �������� ���̸� ó�� �ӵ��� ��ȯ�Ѵ�
            speed = swipeLength / 500.0f;   // 500�� ������ ��������.
                                            // input.mousePosition���� ������� ���Ͱ��� �ػ��� ������ ����

            // ȿ������ ���
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(speed, 0, 0);  // �̵�
        this.speed *= 0.98f;                    // ����
    }

}
