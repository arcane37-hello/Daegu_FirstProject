using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SwordMan fighter1;
    SwordMan fighter2;
    SwordMan fighter3;
    int number = 10;
    Transform trans;

    void Start()
    {
        #region Ŭ���� �ν��Ͻ� (��ü) ����
        // fighter = new SwordMan();
        // fighter.Move();
        // fighter.hp = 200;
        // fighter.attackPower = 10;
        // fighter.Attack("�÷��̾�");
        #endregion

        #region ������(Constructor) ����
        // fighter1 = new SwordMan(50, 5.5f, "���� �˻�");
        // fighter2 = new SwordMan(100, 8.0f, "����� �˻�");
        // fighter3 = new SwordMan(250, 12.0f, "������ �˻�");

        // fighter1.name = "���� �˻�";
        // fighter1.Move();

        // fighter2.name = "����� �˻�";
        // fighter2.Move();

        // fighter3.name = "������ �˻�";
        // fighter3.Move();
        #endregion



        // SwordMan fighter = new SwordMan(200, 10, "�ְ�");
        SwordMan fighter = new SwordMan();

        // Property�� ����Ͽ� ������ �����ϱ�
        // fighter.healthPoint = 500;
        // print(fighter.healthPoint);

        // �Լ��� ����Ͽ� ������ �����ϱ�
        // fighter.SetHP(500);
        // int hp = fighter.GetHP();
        // print(hp);
    }

    void Update()
    {
        
    }

    // void TestFunction()
    // {
    //    for(int i = 0; i < 3; i++)
    //    {
    //        int number = 0;
    //        number += 10;
    //        print(number);
    //    }

    //    for (int i = 0; i < 3; i++)
    //    {
    //        int number = 0;
    //        number = 0;
    //        number += 10;
    //        print(number);
    //    }
    // }
}
