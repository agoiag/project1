using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class study_3 : MonoBehaviour
{
    public Image defaultImage;
    public TextMeshProUGUI gd;//��差
    public Sprite gdimage;//����̹���
    public TextMeshProUGUI em;//���޶��差
    public Sprite emimage;//���޶����̹���
    public TextMeshProUGUI rb;//���
    public Sprite rbimage;//����̹���
    int goldValue=0;
    int emeraldValue = 0;
    int rubyValue = 0;
    public Button click;//Ŭ��

    //List ����
    // List<������ ����> ����Ʈ �̸� = new List<������ ����>();
    // ũ�⸦ �����ϰ� ����� ���� ����
    // List<DataType> name = new List<DataType>(new DataType[siz])
    // �� ��� size¥�� ����Ʈ�� ����.
    // List<string>ssh = new List<string>() {"�ż�ȣ", "�ٺ�"};
    // �� �̷��� ssh ����Ʈ �ȿ� 0��°�� "�ż�ȣ" 1��°�� "�ٺ�"
    // ssh[0] = "�ż�ȣ", ssh[1] = "�ٺ�"
    // ����Ʈ�� �ٸ� ����Ʈ�� �޾Ƽ� ���� �� �� ����.
    // List<string> yyw = new List<string>(ssh);
    // �� yyw = ssh
    // ����Ʈ�� ������ �߰� �ϴ� ���
    // Add �Լ� �̿�
    // ��� ����Ʈ�� �� �ڿ� �߰��ϴ� �����.
    List<string> ssh = new List<string>();// ssh��� ������ ����Ʈ �ʱ�ȭ

    public void Onclick()
    {
        int random = Random.Range(0, 3);//��������
        int randValue = Random.Range(1, 101);

        switch (random)
        {
            case 0:
                goldValue += randValue;
                gd.text = "���:" + goldValue;
                defaultImage.sprite = gdimage;
                break;
            case 1:
                emeraldValue += randValue;
                em.text = "���޶���:" + emeraldValue;
                defaultImage.sprite = emimage;
                break;
            case 2:
                rubyValue += randValue;
                rb.text = "���:" + rubyValue;
                defaultImage.sprite = rbimage;
                break;

        }
    }
    public void OnClick100()
    {
        for (int i = 0; i < 101; i++)
        {
            int random = Random.Range(0, 3);//��������
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
                gd.text = "���:" + goldValue + " ���޶���:" + emeraldValue + " ���:" + rubyValue;
    }
    void Start()
    {
        ssh.Add(" �� �� ȣ ��");
        //���⼭�� ssh �ʱ�ȭ �� ������ ���� �ȳ־��� size�� 0�� (�ƹ��͵� ����.)
        //�׷��� " �� �� ȣ �� "�� ssh[0]�� ��.
        ssh.Add(" �� �� ȣ ��");
        // �߰��� " �� �� ȣ �� "�� ssh[1]�� ��ġ

        //insert �Լ� �̿� ���
        // �� �״�� ���� �ִ� �����
        // ���� �����ϱ� ������ �ִ� �ֵ��� �ڷ� �и�.
        ssh.Insert(0, " �� �� �� �� ");
        // �̷��� ssh��?
        //[�������, �ż�ȣ��, �ż�ȣ��]
        //insert�� �������� �� ���

        // �迭, ����Ʈ�� ũ�⸦ ���ϴ� ���
        // �迭�� ���
        // �迭�̸�. Length;
        // ����Ʈ�� ���
        // ����Ʈ�̸�. Count;
        // �迭�� ����Ʈ�� ũ�⸦ ���ϴ� ����� �ٸ�.
        // ����� �ٸ��� ����Ʈ�� �迭�� �̸��� ����ϰ� ������?
        // �迭�̸�. Count; �̷��� �Ϸ��� �ؼ� ������ ���� ����.

        // ����Ʈ���� ������ �����ϴ� ���
        // - Remove �Լ�
        // ���ϴ� "��"�� ã�Ƽ� ����
        // ���� ���� �������� �� ó�� ���� ����µ�...
        // ���� ID�� ������ 3���� �� 2��°�� ������ �ϴ� ��Ȳ������?

        // - RemoveAt �Լ� ���
        // ��� �ε��� ������ ����.
        // �迭�� �����ϰ� 0���� ����

        // �̰� ���� RemoveAll, Clear �Լ��� ����.
        // �ٵ� �Ⱦ� ��.
        // RemoveAll ���
        // ����Ʈ�̸�.RemoveAll(x => x == "yyw");
        // x => x== "yyw" �� �κ��� ���ٽ��̶� �ϴµ�...
        // ���� ��.
        // ����Ʈ�̸�.RemoveAll(x => x == "yyw");
        // ������ x �� yyw�� �ָ� ��� ����ٴ� ����.

        // lua ������ �����
        // for i = 1, i <= 9 do
        // for d = 1, s <= 9 do
        // print i * s
        //  end
        //end

        //C#�� �߰�ȣ{}�� ���� ��.
        // for����
        for (int i = 0; i < 9; i++)
        {
            //i�� 0���� ����
            // i < 9 : 9���� ���� ������
            //i++ : i�� 1�� ����
        }

        int sum = 0;//�հ踦 ���� ������ ����
        int odd = 0;//Ȧ�� ������ ���� ������ ����
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
        // ����ġ
        // �굵 ���ǿ� ���� �����. (if�� ���)
        // �ٵ� ��� �ϳ��� ���� �����ؼ� ��ġ�ϴ� ��쿡�� �ش� ��ɾ �����ϴ� ���.
        // ��, �� ���� �Ұ�
        // ��Ȯ�� ��ġ�ϴ� ���� �־�� �� �� ����.



        //switch (�񱳰�)
        // ��ȭ�� �ش��ϴ� ��������. ID���� ������ ����. ���� ������ ������ ������ ���� ����. > switch���� ������ �Ǵ�
        //{
        //    case ��ġ��1:
        //          ������ ��ɾ�
        //      break;
        //    case ��ġ��2:
        //          ������ ��ɾ�
        //      break;
        //   default:
        //          ��ġ���� ���� �� ������ ����
        //          if�� ġ�� else�� �ش�
        //      break;

        //}

        // ���ڱ� �����
        // ���� 1���� ���, ���޶���, ��� �� 1���� ����
        // ���� 1���� ��ȭ ���� ������ 1~100 ����(���� �Ȱ���)
        //100�� ���� �� ������ ��� ��
        //���� ��ȭ ���� �־�� ��.
        //���� �̹���, ����
        //������ id ������

        //int randValue;
        //randValue = Random.Range(0, 3);// int�� �� �� �� ���� ����. 0,1,2�� ����

        //randValue = (int)Random.RandomRange(0f, 3f);

        // ����Ű alt + shift + a
        
        //��í �ù� �����
        // - ����� 1~5������� ����
        // - ��޺� Ȯ���� ���޵Ǵ� ������ ������ ����
        // ��1: 20%, 2: 30%, 3: 40%, 4: 8%, 5: 2%
        // ��1: 20~30��, 2: 15~25��, 3:10~20��, 4: 5~10��, 5: 1~5��
        // - 100���� ���� �� ��޸��� � �� ���Դ��� ���






        }

    }