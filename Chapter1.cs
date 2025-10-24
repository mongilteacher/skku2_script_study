using UnityEngine;


public class Chapter1 : MonoBehaviour
{
    void Start()
    {
        // 변수(Variable)
        // 변수: 게임 데이터를 담을 수 있는 영역(상자)
        // - 이 상자를 어디서 활용할 것인지?
        // - 어떤 데이터를 담을것인지?
        // - 이 상자의 이름을 뭐라고 할것인지?

        // 변수 선언  (변수 생성법)
        // <자료형> <변수 이름> = <값>;
        // ;: 세미콜론은 문장(명령어)의 끝을 의미합니다.
        
        // 숫자 자료형: (정수(int) vs 실수(double)
        int health    = 305;         // 체력 데이터를 저장할 변수
        int Health    = 777;         // 변수의 이름은 대,소문자를 구분한다.

        health        = 100;        // 변수의 값은 수정할 수 있다.

        int damage    = 500;         // 대미지 데이터를 저장할 면수
        double weight = 57.3;        // 몸무게를 저장할 변수
        
        // 문자열 자료형: string
        string name = "용감한쿠키";  // 이름을 저장할 변수

        // bool 자료형 (참(true)과 거짓(false)의 값)
        bool isDie = false;          // 죽었니?를 저장할 변수

        Debug.Log("게임이 시작됬습니다.");
        Debug.Log(health);
        Debug.Log(damage);
        Debug.Log(weight);
        Debug.Log(name);
        Debug.Log(isDie);

        // 지금까지가  "기본" 자료형 or "원시" 자료형

        // 사용자 정의 자료형
        // class, struct, enum : 위 데이터들을 묶어서 나만의 자료형을 만든다..
    }
}
