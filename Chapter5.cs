using UnityEngine;

// 연산자
public class Chapter5 : MonoBehaviour
{
    void Start()
    {
        // 연산: 변수들을 이용해서 어떤 결과를 얻는 것
        //  ㄴ 주어진 식을 계산해서 결과를 얻는 것


        // 연산자: 연산할때 필요한 기호

        // 1. 산술 연산자
        // -> 사칙연산(+ - * / %)을 수행하는 연산자
        int a = 5 + 6;  // 연산의 결과는 왼쪽(변수)에 저장된다.
        Debug.Log(a);

        int b = a - 3;
        Debug.Log(b);

        int c = 7 * b;
        Debug.Log(c);

        // 정수 -> 소수 형변환
        // 정수에서 소수로 암시적 형변환이 일어났다.
        // 소수점 아래 숫자들이 사라지는 문제가 일어난다.
        float d = (float)27 / 4; // 6.75
        //Debug.Log(d);   // 6 
        Debug.Log(d);


        // 나머지 연산자
        int e = 27 % 4;
        Debug.Log(e);



        // 2. 대입(할당) 연산자
        int number = 7;      // 7  // = : 오른쪽의 값을 왼쪽에 대입(할당)
        number = number + 2; // 9
        number *= 3;         // number = number * 3; : 곱셈 대입 연산자
        number -= 8;         // number = number - 8; : 뺄셈 대입 연산자


        // 3. 증감 연산자(값이 1씩 증가/감소할 때 사용하는 연산자)
        int age = 28;
        age = age + 1;
        age += 1;            // 덧셈 대입 연산자
        age++;               // age = age + 1;
        age--;               // age = age - 1;
    }
}
