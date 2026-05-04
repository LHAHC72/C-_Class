using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // 정수 데이터 값 입력
    public int answer = 0;

    void Start()
    {

        // 1번 답을 선택했습니다, 2번 답을 선택했습니다, 3번 답을 선택했습니다, 4번 답을 선택했습니다. 출력.
        // 넷 다 아닐 경우 잘 못 선택했습니다 출력

        /*switch (answer)
        {
            case 1:
                
                break;

            case 2:
                Debug.Log("2번 답을 선택했습니다.");
                break;

            case 3:
                Debug.Log("3번 답을 선택했습니다.");
                break;

            case 4:
                Debug.Log("4번 답을 선택했습니다.");
                break;

            default:
                Debug.Log("잘못선택했습니다.");
                break;
        }*/

        // 위에 switch문을 if문으로 구현해보세요.

        if(answer == 1)
        {
            Debug.Log("1번 답을 선택했습니다.");
        }
        else if (answer == 2)
        {
            Debug.Log("2번 답을 선택했습니다.");
        }
        else if (answer == 3)
        {
            Debug.Log("3번 답을 선택했습니다.");
        }
        else if (answer == 4)
        {
            Debug.Log("4번 답을 선택했습니다.");
        }
        else
        {
            Debug.Log("잘못선택했습니다.");
        }

    }

}
