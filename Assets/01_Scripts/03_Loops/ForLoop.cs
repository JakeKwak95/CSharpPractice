using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int start = 0;
	int length = 5;


	void Start()
    {
		// int i = start 시작점
		// i < length 조건, 조건이 참인 동안 반복
		// i++ 증감식

		// for 반복문
		for (int i = start; i < length; i++)
        {
			// 조건이 i < length 인 동안 반복
			// i 값이 0부터 시작해서 length(5) 미만까지 1씩 증가
			// i 값이 5가 되면 조건이 거짓이 되어 반복 종료 (5 < 5 는 거짓)
			// 출력: 0, 1, 2, 3, 4
			Debug.Log("For Loop Count: " + i);
		}

		// for 반복문 응용 (감소)
		for (int j = 10; j > 0; j -= 2)
		{
			// j 값이 10부터 시작해서 0 초과까지 2씩 감소
			// j 값이 0 이하가 되면 조건이 거짓이 되어 반복 종료 (0 > 0 는 거짓)
			// 출력: 10, 8, 6, 4, 2
			Debug.Log("For Loop Decrease Count: " + j);
		}

		// 중첩 for 반복문 (Nested For Loop)
		for (int x = 1; x <= 3; x++)
		{
			// 조건이 x <= 3 인 동안 반복이므로 x 값이 1부터 3까지 출력
			for (int y = 1; y <= 2; y++)
			{
				Debug.Log($"Nested For Loop - x: {x}, y: {y}");
			}
		}
	}
}
