using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        // Здороье
        int health = 5;
        //Уровень
        int level = 1;
        //Скорость
        float speed = 1.5f;

        //Обновлённое здоровье
        health += level;
    }

    // Update is called once per frame
    void Update()
    {

        //Скорость
        float speed = 1.5f;

        //Создание вектора
        Vector3 newPosition;
        //Присвоение значения
        newPosition = transform.position;

        //Высчитывание новой позиции
        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
