using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    //������ ���� �����ϱ�
    public int numberInt1 = 6;
    public int numberInt2 = 3;
    int numberSum;
    int numberSubtract;
    int numberMultiply;
    int numberDivide;
    int numberRemainder;

    // �Ǽ��� ���� �����ϱ�
    public float numberFloat1;
    public float numberFloat2;
    float numberResult;

    // ���ڿ� ���� �����ϱ�
    public string name = "�ڼ���";
    string job = "�л�";

    // ���� ���� �����ϱ�
    private bool isMan;
    
    // Start is called before the first frame update
    void Start()
    {
        // ������ ����
        // ���� �̸� = ��;
        // numberSum = numberInt1 + numberInt2;
        // numberRemainder = numberInt1 % numberInt2;
        // number = 50;
        // number2 = 3.141592f;
        // name = "�ڼ���";
        // isMan = true;

        // numberResult = (float) numberInt1 + (float) numberInt2;
        // ��Ģ ������: + - * / %

        // ���ڿ� + ���ڿ� -> �� ���ڿ��� ����ȴ�.
        // ���� �Ǵ� �Ǽ��� ���ڿ��� ����ȯ�ϰ� ���� ��: ������.ToString()
        // string result = name + numberInt1.ToString();
        // print(result);
        //print(numberSum);
        //print(numberRemainder);

        //numberInt1�� numberInt2 ������ �հ� ���� ����Ѵ�
        numberSum = Sum(numberInt1, numberInt2);
        print(numberSum);

        numberSubtract = Subtract(numberInt1, numberInt2);
        print(numberSubtract);

        numberMultiply = Multiply(numberInt1, numberInt2);
        print(numberMultiply);

        numberResult= Divide(numberInt1, numberInt2);
        print(numberResult);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �Լ� ����
    // ��ȯ �ڷ��� �Լ� �̸� (�Ű�����1, �Ű�����2, ...)
    // {
    //       �� ��
    // }

    // �� ������ �Է¹޾Ƽ� �� �� ���� �հ� ���� ��ȯ�ϴ� �Լ��� ����� �ʹ�
    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    // �� ������ �Է¹޾Ƽ� �� �� ���� ���� ���� ��ȯ�ϴ� �Լ��� ����� �ʹ�
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    // �� ������ �Է¹޾Ƽ� �� �� ���� ���� ���� ��ȯ�ϴ� �Լ��� ����� �ʹ�
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    // �� ������ �Է¹޾Ƽ� �� �� ���� ���� ���� ��ȯ�ϴ� �Լ��� ����� �ʹ�
    // �Է¹��� ������ �Ǽ��� �ӽ� ����ȯ�Ѵ�
    float Divide(int num1, int num2)
    {
        return (float) num1 / (float) num2;
    }
}
