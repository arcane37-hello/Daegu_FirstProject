using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    //정수형 변수 선언하기
    public int numberInt1 = 6;
    public int numberInt2 = 3;
    int numberSum;
    int numberSubtract;
    int numberMultiply;
    int numberDivide;
    int numberRemainder;

    // 실수형 변수 선언하기
    public float numberFloat1;
    public float numberFloat2;
    float numberResult;

    // 문자열 변수 선언하기
    public string name = "박세훈";
    string job = "학생";

    // 논리형 변수 선언하기
    private bool isMan;
    
    // Start is called before the first frame update
    void Start()
    {
        // 변수의 사용법
        // 변수 이름 = 값;
        // numberSum = numberInt1 + numberInt2;
        // numberRemainder = numberInt1 % numberInt2;
        // number = 50;
        // number2 = 3.141592f;
        // name = "박세훈";
        // isMan = true;

        // numberResult = (float) numberInt1 + (float) numberInt2;
        // 사칙 연산자: + - * / %

        // 문자열 + 문자열 -> 두 문자열이 연결된다.
        // 정수 또는 실수를 문자열로 형변환하고 싶을 때: 변수명.ToString()
        // string result = name + numberInt1.ToString();
        // print(result);
        //print(numberSum);
        //print(numberRemainder);

        //numberInt1과 numberInt2 변수의 합계 값을 출력한다
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

    // 함수 선언
    // 반환 자료형 함수 이름 (매개변수1, 매개변수2, ...)
    // {
    //       할 일
    // }

    // 두 정수를 입력받아서 그 두 수의 합계 값을 반환하는 함수를 만들고 싶다
    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    // 두 정수를 입력받아서 그 두 수의 차이 값을 반환하는 함수를 만들고 싶다
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    // 두 정수를 입력받아서 그 두 수의 곱셈 값을 반환하는 함수를 만들고 싶다
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    // 두 정수를 입력받아서 그 두 수의 나눔 값을 반환하는 함수를 만들고 싶다
    // 입력받은 정수를 실수로 임시 형변환한다
    float Divide(int num1, int num2)
    {
        return (float) num1 / (float) num2;
    }
}
