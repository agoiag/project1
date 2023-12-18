using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class study_3 : MonoBehaviour
{
    public Image defaultImage;
    public TextMeshProUGUI gd;//골드량
    public Sprite gdimage;//골드이미지
    public TextMeshProUGUI em;//에메랄드량
    public Sprite emimage;//에메랄드이미지
    public TextMeshProUGUI rb;//루비량
    public Sprite rbimage;//루비이미지
    int goldValue=0;
    int emeraldValue = 0;
    int rubyValue = 0;
    public Button click;//클릭

    //List 선언
    // List<데이터 삽입> 리스트 이름 = new List<데이터 삽입>();
    // 크기를 지정하고 만들고 싶을 때는
    // List<DataType> name = new List<DataType>(new DataType[siz])
    // ㄴ 빈거 size짜리 리스트를 만듦.
    // List<string>ssh = new List<string>() {"신성호", "바보"};
    // ㄴ 이러면 ssh 리스트 안에 0번째는 "신성호" 1번째는 "바보"
    // ssh[0] = "신성호", ssh[1] = "바보"
    // 리스트는 다른 리스트를 받아서 대입 할 수 있음.
    // List<string> yyw = new List<string>(ssh);
    // ㄴ yyw = ssh
    // 리스트에 데이터 추가 하는 방법
    // Add 함수 이용
    // 얘는 리스트의 맨 뒤에 추가하는 방법임.
    List<string> ssh = new List<string>();// ssh라는 문자형 리스트 초기화

    public void Onclick()
    {
        int random = Random.Range(0, 3);//랜덤종류
        int randValue = Random.Range(1, 101);

        switch (random)
        {
            case 0:
                goldValue += randValue;
                gd.text = "골드:" + goldValue;
                defaultImage.sprite = gdimage;
                break;
            case 1:
                emeraldValue += randValue;
                em.text = "에메랄드:" + emeraldValue;
                defaultImage.sprite = emimage;
                break;
            case 2:
                rubyValue += randValue;
                rb.text = "루비:" + rubyValue;
                defaultImage.sprite = rbimage;
                break;

        }
    }
    public void OnClick100()
    {
        for (int i = 0; i < 101; i++)
        {
            int random = Random.Range(0, 3);//랜덤종류
            int randValue = Random.Range(1, 101);

            switch (random)
            {
                case 0:
                    goldValue += randValue;
                    defaultImage.sprite = gdimage;

                    break;
                case 1:
                    emeraldValue += randValue;
                    defaultImage.sprite = emimage;
                    break;
                case 2:
                    rubyValue += randValue;
                    defaultImage.sprite = rbimage;
                    break;

            }
        }
                gd.text = "골드:" + goldValue + " 에메랄드:" + emeraldValue + " 루비:" + rubyValue;
    }
    void Start()
    {
        ssh.Add(" 신 성 호 우");
        //여기서는 ssh 초기화 후 별도의 값을 안넣어놨어서 size가 0임 (아무것도 없음.)
        //그래서 " 신 성 호 우 "가 ssh[0]에 들어감.
        ssh.Add(" 신 성 호 이");
        // 추가한 " 신 성 호 이 "는 ssh[1]에 위치

        //insert 함수 이용 방법
        // 말 그대로 끼워 넣는 방식임
        // 끼워 넣으니까 기존에 있던 애들은 뒤로 밀림.
        ssh.Insert(0, " 유 용 워 이 ");
        // 이러면 ssh는?
        //[유용워이, 신성호우, 신성호이]
        //insert는 끼워넣을 때 사용

        // 배열, 리스트의 크기를 구하는 방법
        // 배열일 경우
        // 배열이름. Length;
        // 리스트일 경우
        // 리스트이름. Count;
        // 배열과 리스트의 크기를 구하는 방법이 다름.
        // 방법이 다른데 리스트와 배열의 이름이 비슷하게 지으면?
        // 배열이름. Count; 이렇게 하려고 해서 에러가 나올 것임.

        // 리스트에서 데이터 삭제하는 방법
        // - Remove 함수
        // 원하는 "값"을 찾아서 지움
        // 같은 값이 여러개면 맨 처음 값을 지우는데...
        // 같은 ID를 가지는 3마리 중 2번째를 지워야 하는 상황에서는?

        // - RemoveAt 함수 사용
        // 얘는 인덱스 정보로 지움.
        // 배열과 동일하게 0부터 시작

        // 이거 말고도 RemoveAll, Clear 함수가 있음.
        // 근데 안쓸 듯.
        // RemoveAll 사용
        // 리스트이름.RemoveAll(x => x == "yyw");
        // x => x== "yyw" 이 부분은 람다식이라 하는데...
        // 몰라도 됨.
        // 리스트이름.RemoveAll(x => x == "yyw");
        // 내용은 x 가 yyw인 애를 모두 지운다는 내용.

        // lua 구구단 만들기
        // for i = 1, i <= 9 do
        // for d = 1, s <= 9 do
        // print i * s
        //  end
        //end

        //C#은 중괄호{}로 묶어 줌.
        // for문은
        for (int i = 0; i < 9; i++)
        {
            //i가 0부터 시작
            // i < 9 : 9보다 작을 때까지
            //i++ : i를 1씩 증가
        }

        int sum = 0;//합계를 담을 정수형 변수
        int odd = 0;//홀수 수량을 담을 정수형 변수
        // int test = (4/8 ? 0.5)
        // test 

        for (int i = 2; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                int result = i * j;
                Debug.Log(i + " X " + j + " = " + result);
                sum += result;
                if (result % 2 == 1)
                {
                    odd++;

                }
            }
        }
        // 스위치
        // 얘도 조건에 따른 제어문임. (if랑 비슷)
        // 근데 얘는 하나의 값을 참조해서 일치하는 경우에만 해당 명령어를 실행하는 방식.
        // 비교, 논리 연산 불가
        // 정확히 일치하는 값이 있어야 쓸 수 있음.



        //switch (비교값)
        // 재화만 해당하는 랜덤상자. ID값은 정해져 있음. 상자 내용의 종류와 갯수를 랜덤 지급. > switch에서 종류를 판단
        //{
        //    case 일치값1:
        //          실행할 명령어
        //      break;
        //    case 일치값2:
        //          실행할 명령어
        //      break;
        //   default:
        //          일치값이 없을 때 실행할 내용
        //          if로 치면 else에 해당
        //      break;

        //}

        // 상자깡 만들기
        // 상자 1개는 골드, 에메랄드, 루비 중 1종류 지급
        // 상자 1개당 재화 지급 수량은 1~100 랜덤(종류 안가림)
        //100개 깠을 때 각가가 몇개씩 얻나
        //각각 재화 변수 있어야 함.
        //상자 이미지, 갯수
        //아이템 id 아이콘

        //int randValue;
        //randValue = Random.Range(0, 3);// int일 때 끝 값 포함 안함. 0,1,2가 나옴

        //randValue = (int)Random.RandomRange(0f, 3f);

        // 단축키 alt + shift + a
        
        //가챠 시뮬 만들기
        // - 등급은 1~5등급으로 구성
        // - 등급별 확률과 지급되는 수량은 다음과 같음
        // ㄴ1: 20%, 2: 30%, 3: 40%, 4: 8%, 5: 2%
        // ㄴ1: 20~30개, 2: 15~25개, 3:10~20개, 4: 5~10개, 5: 1~5개
        // - 100연차 했을 때 등급마다 몇개 씩 나왔는지 출력






        }

    }