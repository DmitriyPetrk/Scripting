using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] int health = 3;
    [SerializeField] int level = 1;
    [SerializeField] int speed = 2;
    Vector3 newPosition;
    void Start()
    {
        // �������� � �������� npc
        health += level;
        // ���-�� ��������
        print(health);
        //
        newPosition = transform.position;
    }

    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
