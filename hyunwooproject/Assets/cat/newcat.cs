using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newcat : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // ���� ȭ��ǥ�� ������ ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(transform.position.x > -9)
            {
                transform.Translate(-3, 0, 0);            // �������� ��3�� �����δ�
            }

        }

        // ������ ȭ��ǥ�� ������ ��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if((transform.position.x < 9))
            {
                transform.Translate(3, 0, 0); // ���������� ��3�� �����δ�
            }
          
        }

    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}


