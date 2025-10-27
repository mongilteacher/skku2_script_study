using UnityEngine;

public class Chapter6 : MonoBehaviour
{
    void Start()
    {
        // 4. 비교(관계) 연산자
        // 양쪽 값을 비교하여 결과를 참(true) 혹은 거짓(false)으로 판명해주는 연산자
        // 비교: 값이 큰지 작은지 같은지 다른지
        bool result = 7 > 3; // 크냐?
        Debug.Log(result);   // true;

        bool result2 = 10 >= 10; // 같거나 크냐?
        Debug.Log(result2);   // true;

        int number1 = 23;
        int number2 = 27;
        bool result3 = number1 == number2; // 둘이 같나요?
        bool result4 = number1 != number2; // 둘이 다르나요?

        // 지금까지 비교 연산의 결과는 -> true / false

        // 5. 논리 연산자
        // 두 개의 true/false를 연산하여 true/false 결과를 얻는 연산자
        int kdyAge = 29;
        int jmkAge = 26;

        // && : AND 연산자(그리고) -> (두 조건이 모두 참일때 -> 참)
        bool result10 = kdyAge > 27 && jmkAge > 27; // false

        // || : OR  연산자(또는)   -> (두 조건중 하나 이상이 참일때 -> 참)
        bool result11 = kdyAge > 27 || jmkAge > 27; // true

        // !  : NOT 연산자(부정)   -> 참은 거짓으로, 거짓은 참으로
        bool result12 = !(kdyAge > 27); // false


        // 괄호 연산자: 연산의 우선순위를 변경
        int numberResult = (3 + 7) * 10; // 
    }
}
