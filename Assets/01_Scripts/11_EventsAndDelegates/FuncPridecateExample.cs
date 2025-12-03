using System;
using UnityEngine;

public class FuncPridecateExample : MonoBehaviour
{
	// Func 또한 delegate 타입의 일종으로, 반환값이 있는 메서드를 참조하는 데 사용됩니다.
	// 마지막 타입 매개변수가 반환값의 타입을 나타내며, 그 이전의 타입 매개변수들은 메서드의 매개변수 타입을 나타냅니다.
	Func<int> noParamFuncExample;
    Func<float, float> oneParamFuncExample;
    Func<string, int, char> twoParamFuncExample;

	// Predicate는 특정 타입의 매개변수를 받아서 bool 값을 반환하는 메서드를 참조하는 데 사용됩니다.
	// 일반적으로 조건 검사를 위해 사용됩니다.
	// 하나의 매개변수만을 가지며, 그 매개변수의 타입을 지정합니다.
	Predicate<int> predicateExample; 

	private void OnEnable()
	{
		// Func 타입의 델리게이트에 메서드를 구독합니다.
		noParamFuncExample += NoParamMethod;
		oneParamFuncExample += OneParamMethod;
		twoParamFuncExample += TwoParamMethod;
		// Predicate 타입의 델리게이트에 메서드를 구독합니다.
		predicateExample += PredicateMethod;
	}

	private void OnDisable()
	{
		noParamFuncExample -= NoParamMethod;
		oneParamFuncExample -= OneParamMethod;
		twoParamFuncExample -= TwoParamMethod;

		predicateExample -= PredicateMethod;
	}

	private void Start()
	{
		int noParamResult = noParamFuncExample.Invoke();
		float oneParamResult = oneParamFuncExample.Invoke(3.2f);
		char twoParamResult = twoParamFuncExample.Invoke("abcdefg", 1);

		bool predicateResult10 = predicateExample.Invoke(10);
		bool predicateResult0 = predicateExample.Invoke(0);

		Debug.Log($"0 줘! : {noParamResult}");
		Debug.Log($"3.2 제곱은 : {oneParamResult}");
		Debug.Log($"abcdefg에서 2번째 글자는 : {twoParamResult}");

		Debug.Log($"10 > 0: {predicateResult10}");
		Debug.Log($"0 > 0: {predicateResult0}");
	}

	private int NoParamMethod()
	{
		return 0;
	}

	private float OneParamMethod(float value)
	{
		float squaredValue = value * value;
		return squaredValue;
	}

	private char TwoParamMethod(string message, int index)
	{
		char letter = message[index];
		return letter;
	}

	private bool PredicateMethod(int value)
	{
		return value > 0;
	}
}
