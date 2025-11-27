using UnityEngine;

// 상속받는 클래스 뒤에 인터페이스를 콤마로 구분하여 나열
// 인터페이스의 경우 클래스와 다르게 다중 상속이 가능
public class InterfaceExample : MonoBehaviour, ITestable
{
	// 인터페이스 타입 변수는 인스펙터에 노출되지 않음
	public ITestable testableInstance;

	public GameObject otherGameObject;

	private void Start()
	{

		// 다른 게임 오브젝트에서 ITestable 인터페이스를 구현한 컴포넌트를 가져옴
		// TryGetComponent 메서드는 컴포넌트가 존재하면 true를 반환하고, 없으면 false를 반환
		// out 키워드는 메서드가 반환하는 값을 저장할 변수를 지정
		if (otherGameObject != null && otherGameObject.TryGetComponent(out testableInstance))
		{
			Debug.Log($"{name} : 다른 게임 오브젝트에서 ITestable 인터페이스를 구현한 컴포넌트를 찾았습니다.");
			// 인터페이스 메서드 호출
			testableInstance.Test();
		}
		else
		{
			Debug.LogWarning($"{name} : 다른 게임 오브젝트에서 ITestable 인터페이스를 구현한 컴포넌트를 찾지 못했습니다.");
			Test();
		}
	}

	// ITestable 인터페이스의 Test 메서드 구현
	public void Test()
	{
		Debug.Log($"{name}: ITestable 인터페이스의 Test 메서드가 호출되었습니다.");
	}
}