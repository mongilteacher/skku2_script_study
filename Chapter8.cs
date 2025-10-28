using UnityEngine;

public class Chapter8 : MonoBehaviour
{
    public string MBTI = "ESTP";

    public int Score;
    /**
    Score 점수(0~100)을 입력받아 
    반드시 switch문을 이용하여 학점을 출력하는 프로그램을 작성하시오.
     - 100 A+, 
     - 90~99 A, 
     - 80~89 B,
     - 70~79 C, 
     - 60~69 D, 
     - 60미만 F를 부여한다.
    **/

    void Start()
    {
        switch(Score/10)
        {
            case 10:
            {
                Debug.Log("A+");
                break;
            }

            case 9:
            {
                Debug.Log("A");
                break;
            }

            case 8:
            {
                Debug.Log("B");
                break;
            }

            default:
            {
                Debug.Log("F");
                break;
            }
        }

        // 과제
    }
}
