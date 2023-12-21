using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;  //화살 생성주기
    float delta = 0;    //생성 주기 확인

    void Update()
    {   //deltaTime을 더했을 때 1이 됨. deltaTime : 기다리는 시간. deltaTime이 지나면 생성이 되어야 한다.
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;  //재생성이 되었을 때, 재생성 시간을 초기화시켜서 다시금 재생성이 되도록 함.
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);   // -6 ~ 6 까지 재생성
            go.transform.position = new Vector3(px, 7, 0); // 재생성 된 오브젝트의 위치를 바꿔줌.
        }
    }
}
