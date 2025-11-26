using UnityEngine;

public class WhileLoop : MonoBehaviour
{
	private void Start()
	{
		int count = 0;

		// 괄호 안의 조건이 참인 동안 반복
		while (count < 5)
		{
			Debug.Log("While - Count 값: " + count);
			count++;
		}

		Debug.Log("---");

		while (false)
		{
			// 이 코드는 절대 실행되지 않음
			Debug.Log("메롱~");
		}

		while (true)
		{
			Debug.Log("While - Count 값: " + count);
			count++;
			if (count >= 10)
			{
				Debug.Log("While 무한 루프 탈출! Count 값: " + count);
				break; // break만나면 와일 루프 탈출
			}
		}
		// 주의: 무한 루프에 빠지지 않도록 조심!
		// 무한 루프에 빠지면 프로그램이 멈추거나 강제 종료될 수 있음


		// Do While 예제

		int number = 0;

		// Do While은 While과 달리 최소 1번은 실행됨
		do
		{
			Debug.Log("Do While - number 값: " + number);
			number++;
		}
		while (number < 3);

		// While vs Do While 차이 예제

		int a = 5;

		while (a < 5)
		{
			Debug.Log("While 문: a < 5 조건이 false라서 실행되지 않습니다.");
		}

		do
		{
			Debug.Log("Do While 문: 조건이 false여도 최소 한 번은 실행됩니다!");
		}
		while (a < 5); // false이므로 1회만 실행됨
	}
}
