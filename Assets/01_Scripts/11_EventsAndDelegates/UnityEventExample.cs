using System;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventExample : MonoBehaviour
{
	// Action과 같이 반환 값이 없는 이벤트를 정의합니다.
	// UnityEvent는 인스펙터 창에서 이벤트를 설정할 수 있도록 해줍니다.
	// 인스펙터 창에서 설정한 매서드들이 먼저 호출 된 후 스크립트에서 추가한 매서드들이 호출됩니다.
	public UnityEvent OnStart;
	//  Action과 같이 매개 변수가 있는 이벤트를 정의 할 수 있습니다.
	public UnityEvent<int> OnStartWithInt;
	
	public int exampleValue = 10;

	private void Start()
	{
		// ?을 붙이는 이유는 null일 경우 호출을 방지하기 위해서입니다.
		OnStart?.Invoke();
		OnStartWithInt?.Invoke(exampleValue);
	}

	private void OnEnable()
	{
		// += 대신 AddListener를 사용하여 이벤트에 메서드를 구독합니다.
		OnStart.AddListener(HandleOnStart);
		OnStartWithInt.AddListener(HandleOnStartWithInt);
	}


	private void OnDisable()
	{
		// -= 대신 RemoveListener를 사용하여 이벤트에서 메서드 구독을 해제합니다.
		OnStart.RemoveListener(HandleOnStart);

		// 모든 리스너를 제거하려면 RemoveAllListeners를 사용합니다.
		OnStart.RemoveAllListeners();
		OnStartWithInt.RemoveAllListeners();
	}

	private void HandleOnStart()
	{
		Debug.Log("OnStart 이벤트가 호출되었습니다.");
	}

	private void HandleOnStartWithInt(int arg0)
	{
		Debug.Log($"OnStartWithInt 이벤트가 호출되었습니다. 전달된 값: {arg0}");
	}

	// 인스펙터 창에서 호출할 수 있는 메서드 예제
	// 접근 제한자는 public이어야 합니다.
	public void SayHi()
	{
		Debug.Log("안녕!");
	}

}
