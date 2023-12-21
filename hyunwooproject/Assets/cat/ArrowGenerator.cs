using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;  //ȭ�� �����ֱ�
    float delta = 0;    //���� �ֱ� Ȯ��

    void Update()
    {   //deltaTime�� ������ �� 1�� ��. deltaTime : ��ٸ��� �ð�. deltaTime�� ������ ������ �Ǿ�� �Ѵ�.
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;  //������� �Ǿ��� ��, ����� �ð��� �ʱ�ȭ���Ѽ� �ٽñ� ������� �ǵ��� ��.
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);   // -6 ~ 6 ���� �����
            go.transform.position = new Vector3(px, 7, 0); // ����� �� ������Ʈ�� ��ġ�� �ٲ���.
        }
    }
}
