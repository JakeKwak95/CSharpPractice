using UnityEngine;

public class BasicMethods : MonoBehaviour
{
	int a = 10;
	int b = 20;

	// 시작 시점에 호출되는 유니티 메소드
	private void Start()
	{
		// Debug.Log 도 메소드의 한 종류
		Debug.Log("=== Basic Methods Example ===");

		// 반환값 없는 메소드 호출
		SayHello();

		// 반환값 있는 메소드 호출
		Debug.Log($"Pi value is: {GetPiValue()}");

		// 매개변수 있는 메소드 호출
		int sumResult = AddNumbers(a, b);
		Debug.Log($"{a} + {b} = {sumResult}");

		// 기본 값 매개변수 메소드 호출
		GreetPlayer(); // 기본 값 사용, 매개변수를 전달하지 않을 시 기본 값 사용
		GreetPlayer("Alice"); // 사용자 지정 값 사용
	}

	// 반환값 없는 메소드
	void SayHello()
	{
		// 특정한 로직을 메서드 안에 작성하여 재사용 가능
		Debug.Log("Hello! This is a basic method.");
	}

	// 반환값 있는 메소드
	float GetPiValue()
	{
		// 함수가 호출 될 때 원주율 값을 반환
		return 3.14f;
	}

	// 반환값 있는 메소드
	int AddNumbers(int a, int b) // 매개변수를 활용하여 다른 값들로 로직을 수행할 수 있음
	{
		// 함수가 호출 될 때 두 수를 더한 결과를 반환
		return a + b;
	}

	// 기본 값 매개변수 메소드
	void GreetPlayer(string playerName = "Guest") // 기본 값이 있는 매개변수는 마지막에 위치해야 함
	{
		Debug.Log($"Welcome, {playerName}!");
	}

	// void ErrorMethod(int a = 1, int b) // 오류 발생: 기본 값 매개변수는 마지막에 위치해야 함

}
