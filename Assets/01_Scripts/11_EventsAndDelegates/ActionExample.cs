using System;
using UnityEngine;

public class ActionExample : MonoBehaviour
{
	// Action 또한 delegate 타입의 일종으로, 반환값이 없는 메서드를 참조하는 데 사용됩니다.
	Action noParamActionExample;
	Action<float> oneParamFuncExample;
	Action<string, int> twoParamFuncExample;

	// delegate와 같이 event로도 선언할 수 있습니다.
	event Action NoParamEvent;
	event Action<float> OneParamEvent;
	event Action<string, int> TwoParamEvent;

	private void OnEnable()
	{
		// Action 타입의 델리게이트에 메서드를 구독합니다.
		// 이때 구독 정보는 어플리케이션이 비활성화 되어도 유지됩니다.
		// 따라서 오브젝트가 활성도될 때 구독하고, 비활성화될 때 구독 해제하는 것이 좋습니다.
		noParamActionExample += NoParamMethod;
		oneParamFuncExample += OneParamMethod;
		twoParamFuncExample += TwoParamMethod;
	}

	private void OnDisable()
	{
		// 오브젝트가 비활성화될 때 구독을 해제합니다.
		noParamActionExample -= NoParamMethod;
		oneParamFuncExample -= OneParamMethod;
		twoParamFuncExample -= TwoParamMethod;
	}

	private void Start()
	{
		noParamActionExample.Invoke();
		oneParamFuncExample.Invoke(5.0f);
		twoParamFuncExample.Invoke("abcdefg", 2);
	}

	private void NoParamMethod()
	{
		Debug.Log("매개변수가 없는 Action 호출됨.");
	}
	private void OneParamMethod(float value)
	{
		float squaredValue = value * value;
		Debug.Log($"매개변수가 하나인 Action 호출됨. 값: {value}, 제곱: {squaredValue}");
	}
	private void TwoParamMethod(string message, int index)
	{
		// char은 하나의 문자를 나타내는 데이터 타입입니다.
		// string은 사실상 char의 배열이기 때문에, 인덱스를 사용하여 특정 위치의 문자를 가져올 수 있습니다.
		char letter = message[index];
		Debug.Log($"매개변수가 두 개인 Action 호출됨. 메시지: {message}, 인덱스: {index}, 문자: {letter}");
	}


}
