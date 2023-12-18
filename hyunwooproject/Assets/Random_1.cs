using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


//가챠 시뮬 만들기
// - 등급은 1~5등급으로 구성
// - 등급별 확률과 지급되는 수량은 다음과 같음
// ㄴ1: 20%, 2: 30%, 3: 40%, 4: 8%, 5: 2%
// ㄴ1: 20~30개, 2: 15~25개, 3:10~20개, 4: 5~10개, 5: 1~5개
// - 30연차 했을 때 등급마다 몇개 씩 나왔는지 출력
// - 30번동안 5등급이 안나왔을 경우 30번째는 5등급 1개 확정

//5등급에 변수 > 변수 30이 채워지면 5등급 아이템 획득
public class Random_1 : MonoBehaviour
{
    public TextMeshProUGUI oneRt;//아이템 갯수
    public TextMeshProUGUI twoRt;//아이템 갯수
    public TextMeshProUGUI treeRt;//아이템 갯수
    public TextMeshProUGUI fourRt;//아이템 갯수
    public TextMeshProUGUI fiveRt;//아이템 갯수
    public Sprite ONE_RT;//1등급
    public Sprite TWO_RT;//2등급
    public Sprite THREE_RT;//3등급
    public Sprite FOUR_RT;//4등급
    public Sprite FIVE_RT;//5등급
    int ONE_RTValue = 0;
    int TWO_RTValue = 0;
    int THREE_RTValue = 0;
    int FOUR_RTValue = 0;
    int FIVE_RTValue = 0;

    public void Onclick()
    {
        int random = Random.Range(1, 6);//랜덤 등급
        int randomValue = Random.Range(1, 101);

        switch (random)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
                ONE_RTValue += randomValue;
                oneRt.text = "1등급:" + ONE_RTValue;
                break;
            case 21:
            case 22:
            case 23:
            case 24:
            case 25:
            case 26:
            case 27:
            case 28:
            case 29:
            case 30:
            case 31:
            case 32:
            case 33:
            case 34:
            case 35:
            case 36:
            case 37:
            case 38:
            case 39:
            case 40:
            case 41:
            case 42:
            case 43:
            case 44:
            case 45:
            case 46:
            case 47:
            case 48:
            case 49:
            case 50:
                TWO_RTValue += randomValue;
                twoRt.text = " 2등급:" + TWO_RTValue;
                break;
            case 51:
            case 52:
            case 53:
            case 54:
            case 55:
            case 56:
            case 57:
            case 58:
            case 59:
            case 60:
            case 61:
            case 62:
            case 63:
            case 64:
            case 65:
            case 66:
            case 67:
            case 68:
            case 69:
            case 70:
            case 71:
            case 72:
            case 73:
            case 74:
            case 75:
            case 76:
            case 77:
            case 78:
            case 79:
            case 80:
            case 81:
            case 82:
            case 83:
            case 84:
            case 85:
            case 86:
            case 87:
            case 88:
            case 89:
            case 90:
                THREE_RTValue = randomValue;
                treeRt.text = " 3등급:" + THREE_RTValue;
                break;
            case 91:
            case 92:
            case 93:
            case 94:
            case 95:
            case 96:
            case 97:
            case 98:
                FOUR_RTValue = randomValue;
                fourRt.text = " 4등급:" + FOUR_RTValue;
                break;
            case 99:
            case 100:
                FIVE_RTValue = randomValue;
                fiveRt.text = " 5등급:" + FIVE_RTValue;
                break;



        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
