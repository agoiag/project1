using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class Study_01 : MonoBehaviour
{
    // Start is called before the first frame update
    int test;
    /*   void Awake()
       {
       Debug.LogError("Awake");
       }
       void FixedUpdate()
       {
       Debug.LogWarning("FixedUpdate");
       }
       void LateUpdate()
       {
           Debug.LogError("LogError");
       }
    */
    void Start()
    {
        Debug.Log("start");


        //��ȭ �� �Ѵܰ辿 �ö� �� ����� �� ����
        /*    Debug.Log(test);
            test++;
            Debug.Log(test);
            test += 1;
            Debug.Log(test);
            test = test + 1;
            Debug.Log(test);

            Debug.Log("������");
            Debug.LogWarning("���");
            Debug.LogError("����");
        */
    }
    void OnEnable()//Ȱ��ȭ �� ��
    {
        Debug.Log("������");
    }
    void OnDisable()//��Ȱ��ȭ �ɶ�
    {
        Debug.Log("������");
    }
    void OnDestroy()
    {
        Debug.Log("����! ������ �ڹμ�...");
    }

    //lua = nil
    //c# = null
    // �̰� �ּ� �����̴�.

    /* �̰� �ּ� ������
     *������Ʈ�� �� �����Ӹ��� ����
     * test += 3; < test�� 3�� ���� ���� test��� ǥ��
     * crtl+d > Ŀ���� ��ġ�� �� ����
     * ;�� ��ħǥ ������ ��.
     * ���������Ʒ�ó�� �� ������ ġ�� �ּ�
     */



    // Update is called once per frame

    void Update()
    {
        
        // Debug.Log("Update");    

    }
}