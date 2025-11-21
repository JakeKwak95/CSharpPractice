using UnityEngine;


public enum StateExample
{
	// 열거형의 정수 값을 명시적으로 지정할 수도 있습니다.
	None = -1,

	// 지정하지 않으면 직전 값에서 1씩 증가하는 값을 가집니다.
	Idle,
	Running,
	Jumping,
	Attacking,
	Dead,

	// 마지막에 총 개수를 나타내는 값을 추가하는 관례가 있습니다.
	Max
}

public class EnumBasic : MonoBehaviour
{
	// 인스펙터에서 드롭다운으로 상태를 선택할 수 있습니다.
	public StateExample currentState;
	// EnumButtons 어트리뷰트를 사용하면 버튼 형태로 상태를 선택할 수 있습니다. 어트리뷰트는 추후에 다룰 예정입니다.
	// [EnumButtons] public StateExample currentState;

	private void Start()
	{
		// 열거형은 정수형 값으로 변환할 수 있습니다.
		// 반대로 정수형 값을 열거형 값으로 변환할 수도 있습니다. 예) (StateExample)0 <- Idle
		int randomState = Random.Range(0, (int)StateExample.Max); // Random.Range에 정수형 값을 사용하면 max 값은 포함되지 않습니다.
		ChangeState((StateExample)randomState);
	}

	private void Update()
	{
		// 스위치문과 열거형을 함께 사용하여 상태에 따른 동작을 구현할 수 있습니다.
		switch (currentState)
		{
			case StateExample.None:
				break;
			case StateExample.Idle:
				PrintState(StateExample.Idle);
				break;
			case StateExample.Running:
				PrintState(StateExample.Running);
				break;
			case StateExample.Jumping:
				PrintState(StateExample.Jumping);
				break;
			case StateExample.Attacking:
				PrintState(StateExample.Attacking);
				break;
			case StateExample.Dead:
				PrintState(StateExample.Dead);
				break;
		}
	}

	void ChangeState(StateExample newState)
	{
		if (currentState == newState) return;

		currentState = newState;
	}

	void PrintState(StateExample state)
	{
		Debug.Log($"Current State: {state}");
	}
}
