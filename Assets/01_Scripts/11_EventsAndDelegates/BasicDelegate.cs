using UnityEngine;

// 기본적인 델리게이트 사용 예제
// 델리게이트는 메서드 참조를 저장할 수 있는 타입 안전한 함수 포인터입니다.
// 메서드를 변수에 할당하거나 다른 메서드에 전달할 수 있습니다.
public class BasicDelegate : MonoBehaviour
{
	// 델리게이트 선언
	// 반환형과 매개변수 목록이 메서드 서명과 일치해야 합니다.
	delegate void MessageDelegate(string message);
	delegate int CalculationDelegate(int a, int b);

	// 다른 클래스에서 사용할 델리게이트 선언
	public delegate void SimpleDelegateForOtherClass();
	// 델리게이트 인스턴스, 다른 클래스에서 접근 가능
	public SimpleDelegateForOtherClass simpleDelegate;

	// 다른 클래스의 Start 메서드에서 호출할 수 있도록 Awake에서 할당
	private void Awake()
	{
		simpleDelegate = SimpleMethod;
	}

	private void Start()
	{
		// 델리게이트 인스턴스 생성 및 메서드 할당
		MessageDelegate printer = PrintMessage;
		printer("안녕! 난 델리게이트야!");

		CalculationDelegate adder = Add;
		int result = adder(5, 10);
		Debug.Log($"더함 값 : {result}");
	}

	// 선언한 델리게이트와 매개변수 목록이 일치하는 메서드 생성
	private void PrintMessage(string msg)
	{
		Debug.Log(msg);
	}

	// 선언한 델리게이트와 반환타입 및 매개변수 목록이 일치하는 메서드 생성
	private int Add(int a, int b)
	{
		return a + b;
	}

	void SimpleMethod()
	{
		Debug.Log("간단한 메서드입니다!");
	}
}
