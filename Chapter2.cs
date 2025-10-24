using UnityEngine;


// 변수의 자료형
public class Chapter2 : MonoBehaviour
{
    void Start()
    {
        // 변수가 저장하는 값(데이터)에 따라 타입(자료형)이 다르다.

        // 1.숫자
        // 1-1. 정수형(소숫점이 없는 숫자) : int / long / short / byte
        // 데이터: -3, -2, -1, 0, 1, 2, 3, 1000, 3423 ...
        // 같은 자료형이어도 종류가 여러개인 이유는 담을수 있는 데이터의 크기가 다르다.
        int age = 29;               // -21억 ~ 21억 까지만
        long age2 = 342342323894;   // 더~~~ 큰 숫자를 담을 수 있다. (하지만 차지하는 용량이 더 크다.)  
        int health = 100;

        // 1-2. 실수형(소숫점이 있는 숫자) : float, double, decimal ...
        // 데이터: -1.2, 0.3, 0.48, 0.0001
        // 같은 자료형이더라도 범위 뿐만아니라 '표현할 수 있는 소수점 개수'가 다르다.
        float floatWeight = 55.123456789123456789f;
        double doubleWeight = 55.123456789123456789f;
        Debug.Log(floatWeight);
        Debug.Log(doubleWeight);

        // 2.문자열 (문자들 = 문장)
        // 데이터: "Hello", "A", "안녕 반가워" -> 큰따옴표로 감싸줘야한다.
        string name = "전민관";
        name = "노민균";
        print(name);

        // 3.논리형(bool)
        // 참과 거짓을 저장하는 데이터 타입
        // 데이터: true, false
        bool gameOver = false;
        print(gameOver);

        // 사용자 정의형


        // 불타오르는 레벨 7 전사용 소드
        // 722070301
    }

   
}
