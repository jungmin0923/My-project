using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         {   //�ѹ��� ���� ��
        int age;            //���� age�� ����
        age = 30;           //���� age�� 30�� ���� �Է�
        Debug.Log(age);     //age�� �Էµ� ���� ����Ƽ console â�� ������

        float height1 = 160.5f;         //height�� 160.5 �� ����
        float height2;                  //height2 ����

        height2 = height1;              //height2�� height1���� �Է�
        Debug.Log(height2);             //height2�� �Էµ� ���� ����Ƽ Console â�� ������

        string name;                    //name�� ����
        name = "Sera";                  //name�� sera �Է� 
        Debug.Log(name);                //namedp �Էµ� ���� ����Ƽ Console â�� ������
            
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}