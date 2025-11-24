using UnityEngine;

public class DelegateExampleUsage : MonoBehaviour
{
	public DelegateExample basicDelegateInstance;

	public MulticastDelegate multicastDelegateInstance;

	void Start()
	{
		if (basicDelegateInstance)
		{
			DelegateExample.SimpleDelegateForOtherClass delInstance = ExampleMethod;
			delInstance();
		}

		if (multicastDelegateInstance)
		{
			// event 키워드를 사용하지 않으면 외부 클래스에서 델리게이트에 직접 접근할 수 있습니다.
			multicastDelegateInstance.logDelegate = null;
			multicastDelegateInstance.logDelegate = ExampleMethod;
			multicastDelegateInstance.logDelegate();

			// event 키워드를 사용하면 외부 클래스에서 델리게이트에 직접 접근할 수 없습니다.
			// multicastDelegateInstance.LogEvent();
			// multicastDelegateInstance.LogEvent = null;

			// 구독 및 구독 해제만 가능합니다.
			multicastDelegateInstance.LogEvent += ExampleMethod;
			multicastDelegateInstance.LogEvent -= ExampleMethod;
		}

	}

	void ExampleMethod()
	{
		Debug.Log("다른 클래스에서 선언한 델리게이트를 통해 호출된 메서드입니다.");
	}
}
