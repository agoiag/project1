using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using static System.Net.Mime.MediaTypeNames;

public class talk_script : MonoBehaviour
{
    //�迭
    //���� ������ Ÿ���� ������ ���� ���� ������ ��.
    //�ٵ� �迭�� ũ�Ⱑ ������ ����.

    //�迭 ���� ���
    //dataType[] �迭 �̸� = new dataType[size];
    //dataType[] �迭 �̸� = {���1, ���2, ���3,...};

    //�迭�� 0���� ����

    /*string[] descTextList =
     * { "�ȳ�.",
     * "�� �̸��� �������̾�."
     * "�� ��������."
     * "�����ϴ� �� ����� ���̴�?"
     * �׷� ������ �ϵ���"
     * );
     */

    /*descText.text = descTextList[descNum];
    descTextList��� �迭�� descNum��°�� �ش��ϴ�
    ���� descText.Text�� �ְڴ�.
    */


    /*������Ʈ�� ���� �Լ���?
    gameObject.SetActive(false)
    Ű�°�?
    gameObject.SetActive(true)

    ���� GameObject aaaa�� ��Ƴ��� ������Ʈ��
    aaaa.SetActive(true/false);
    �ƴϸ�
    aaaa.gameObject.SetActive(true/false);

    C#���� ���ڵ��� �����ϴ� ���
    �� ��ƿ����� ..�� ����߾���
    C#�� + �� �����
    �� ���� + ����/����/�������� �����ϰ� ������
    �� string_1 + string/number/var;�� ������
    �� ���ڰ� ����
    �� �� ���� object.text = ���⿡ ������ ��.
    */

    /*[SerializeField]
     * int[] testarray = new int[5];
     * ���� ���� 5ĭ�� �迭��.
     * �׷��� ���� �� �ȳ־��ָ�?
     * �׷���
     * ����Ʈ �� �Ⱦ��Ÿ� 0 or -1�� �־� �ذ���.
     * ������ ������ ����ϱ�.
     * �ڵ� �� �Ǵ��� �� �� ���� �Ǵ��ϴϱ�.
     */

    /*GameObject[]testGame = new GameObject[10];
     * Image[] testImage = new Image[10];
    */
    [SerializeField]
    int descNum;
    public TMP_Text descText;
    public Button startBtn;
    public GameObject textBg;
    public GameObject Bg;

    public void ChangeDesc()
    {
        switch (descNum)
        {
            case 0:
                {
                    textBg.SetActive(true);
                    startBtn.gameObject.SetActive(false);
                    descText.text = "�ȳ�.";
                }
                break;
            case 1:
                {
                    descText.text = "�� �̸��� �������̾�.";
                }
                break;
            case 2:
                {
                    descText.text = "�� ��������.";
                }
                break;
            case 3:
                {
                    descText.text = "�����ϴ� �� ����� ���̴�?";
                }
                break;
            case 4:
                {
                    descText.text = "�����ϴ� �� ����� ���̴�?";
                }
                break;
            case 5:
                {
                    descText.text = "�׷� ������ �ϵ���";
                }
                break;
            case 6:
                {
                    textBg.SetActive(false);
                    Bg.SetActive(true);
                }
                break;
            case 7:
                {
                    textBg.SetActive(true);
                    descText.text = "asdf.";
                }
                break;
            case 8:
                {
                    descText.text = "ASGAG.";
                }
                break;
            case 9:
                {
                    descText.text = "ASDFDHBGH.";
                }
                break;
            case 10:
                {
                    descText.text = "ASDFSAGGREAG.";
                }
                break;
            case 11:
                {
                    descText.text = "AASRHHERRJJYYJTYY.";
                }
                break;
            case 12:
                {
                    //descNum = -1;
                    Bg.SetActive(false);
                    textBg.SetActive(false);
                }
                break;
            case 13:
                {
                    textBg.SetActive(true);
                    descText.text = "����Ʈ����.";
                }
                break;
            case 14:
                {
                    descText.text = "����Ʈ����1.";
                }
                break;
            case 15:
                {
                    descText.text = "����Ʈ����2.";
                }
                break;
            case 16:
                {
                    descText.text = "����Ʈ����3.";
                }
                break;
            case 17:
                {
                    textBg.SetActive(false);
                    descNum = 12;
                }
                break;
            default:
                break;
        }

        descNum++;
    }
}