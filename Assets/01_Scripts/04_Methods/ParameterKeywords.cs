using UnityEngine;

public class ParameterKeywords : MonoBehaviour
{
	int a = 5;
	int b = 6;

	private void Start()
	{
		Debug.Log("=== Parameter Keywords Example ===");

		// 기본 매개변수 전달 (by value)
		Debug.Log("Before: " + a);
		DoubleValue(a);
		Debug.Log("After: " + a); // 매개 변수로 넘겨진 변수는 그 값만 함수 내에서만 존재하는 지역 변수에 사용되어 a의 값은 변하지 않음

		// ref 예제
		Debug.Log("Before Ref: " + b);
		DoubleValueRef(ref b);
		Debug.Log("After Ref: " + b); // ref 키워드를 붙이면 매개 변수의 값이 아닌 매개변수 자체를 전달, b 값이 메소드 안에서 바뀜

		// 복사본과 원본을 넘기는 것의 차이라고 생각하면 됨

		// out 예제
		int c;
		InitializeOut(out c);
		Debug.Log("After Out: " + c); // 메소드 안에서 초기화됨

		InitializeOut(out int e); // 변수의 선언과 초기화를 동시에 진행 할 수 있음
		Debug.Log("After Out + 초기화: " + e); // 메소드 안에서 초기화됨

		// in 예제
		int d = 10;
		int doubled = DoubleValueIn(in d);
		Debug.Log("Original d: " + d + ", Doubled: " + doubled); // d는 그대로
	}

	void DoubleValue(int value)
	{
		value *= 2;
	}

	// ref 키워드: 값이 메소드 안에서 변경되면 호출한 곳에도 반영
	void DoubleValueRef(ref int value)
	{
		value *= 2;
	}

	// out 키워드: 반드시 메소드 안에서 초기화해야 함
	void InitializeOut(out int value)
	{
		value = 100;
	}

	// in 키워드: 읽기 전용, 메소드 안에서 값 변경 불가
	int DoubleValueIn(in int value)
	{
		// value *= 2; // 불가! 읽기 전용
		return value * 2;
	}
}
