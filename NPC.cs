using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        // �������
        int health = 5;
        //�������
        int level = 1;
        //��������
        float speed = 1.5f;

        //���������� ��������
        health += level;
    }

    // Update is called once per frame
    void Update()
    {

        //��������
        float speed = 1.5f;

        //�������� �������
        Vector3 newPosition;
        //���������� ��������
        newPosition = transform.position;

        //������������ ����� �������
        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
