using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < 5; i++)               //0부터 4까지 i 출력
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 0; i < 10; i += 2)            //0부터 9까지 짝수 출력
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 3; i > 0; i--)             //3부터 0까지 내려가면서 i 출력
        //{
        //    Debug.Log(i);
        //}

        for (int i = 0; i < 10; i++)                //0부터 9까지 짝수 출력
        {
            if(i%2 ==0)
            {
                Debug.Log(i);
            }
        }

        Debug.Log("==================================");

        int sum = 0;
        for(int i = 0; i < 10; i ++)
        {
            sum += i;
        }
        Debug.Log(sum);

        Debug.Log("=============구구단==============");

        for(int i = 0; i < 10; i ++)
        {
            for(int j = 0; j < 10; j++)
            {
                Debug.Log(i.ToString() + " x " + j.ToString() + " = " + (i * j).ToString());
            }
        }
        //주석 단축키는 Ctrl + K + C , 주석 풀기는 Crtl + K + U
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
