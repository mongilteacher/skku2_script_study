using UnityEngine;

public class Example2 : MonoBehaviour
{
    public int Number = 3;
   
    void Start()
    {
        // 1번 문제.
        // 만약 Number 숫자가 짝수이면 "짝수입니다." 출력하세요.
        if (Number % 2 == 0) // 조건식: 비교 연산을 하는 식 '>' '<' '>=' '<=' ''==' '!=' 
        {
            Debug.Log("짝수입니다.");
        }
        else // : 위 if가 아니라면~
        {
            Debug.Log("홀수입니다.");
        }


        //               짝수이면 "짝수입니다."



  
    }
}
