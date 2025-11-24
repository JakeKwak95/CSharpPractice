using UnityEngine;

public class DelegateExampleUsage : MonoBehaviour
{
	public BasicDelegate basicDelegateInstance;

	void Start()
	{
		BasicDelegate.SimpleDelegateForOtherClass delInstance = ExampleMethod;
		delInstance();

		basicDelegateInstance.simpleDelegate();
	}
	void ExampleMethod()
	{
		Debug.Log("다른 클래스에서 선언한 델리게이트를 통해 호출된 메서드입니다.");
	}
}
