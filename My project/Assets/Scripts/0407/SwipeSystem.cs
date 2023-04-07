using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{

    public Vector2 initialPos;                      //���콺�� ȭ���� x,y �����Ǹ� �ֱ� ������ Vector2
    public GameObject Character;                    //ĳ���͸� �����Ѵ�. 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);
    }



    void Calculate(Vector3 finalPos)                //����ϴ� �Լ��� �����.
    {
        float disX = Mathf.Abs(initialPos.x - finalPos.x);          //Mathf.abs �Լ��� �������� ���ϴ� �Լ� (�Ÿ��� ���ؾ� �ϱ� ������)
        float disY = Mathf.Abs(initialPos.y - finalPos.y);

        if (disX > 0 || disY > 0)                                   // || <- or�� ��Ÿ���� �� (&&)
        {
            if (disX > disY)
            {
                if (initialPos.x > finalPos.x)
                {
                    Debug.Log("Left"); Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                }
                else
                {
                    Debug.Log("Rigth"); Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
                }
            }
            else
            {
                if (initialPos.y > finalPos.y)
                {
                    Debug.Log("Down"); Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);
                }
                else
                {
                    Debug.Log("Up"); Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);
                }
            }
        }
    }
}