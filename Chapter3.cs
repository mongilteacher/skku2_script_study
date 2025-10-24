using UnityEngine;

// 변수의 범위(종류)
public class Chapter3 : MonoBehaviour
{
    // 클래스 멤버 변수(=프로퍼티)
    // - 클래스 하위에 있는 모든 함수들이 접근 가능하다.
    /** const **/ int age = 71;

    // const: 상수 키워드
    // ㄴ 변수를 선언할 때만 초기값 설정이 가능하고, 그 이후에는 갑 변경 불가

    float height = 178.2f;

    void Start()
    {
        // 지역 변수
        // - 함수(Start) 내부에서 선언되는 변수
        // - 함수 내부({})에서만 사용할 수 있다.
        int health = 100;
        Debug.Log(health);

        age = 81;
        Debug.Log(age);
    }

    void Update()
    {
        int health = 100;
        Debug.Log(health);

        float height = 782.2f;

        height = 190.1f;  // 쉐도잉: 지역변수와 멤버변수의 이름이 같아서 가려지는 현상 (Bad Case)
        Debug.Log(height);
    }
}
