using UnityEngine;

public class MulticastDelegate : MonoBehaviour
{
	public delegate void LogDelegate();

	public LogDelegate logDelegate;
	public event LogDelegate LogEvent;

	private void Start()
	{
		logDelegate = LogA;
		// += 연산자를 사용하여 여러 함수 연결 가능
		logDelegate += LogB; // 여러 함수 연결
		logDelegate();

		// -= 연산자를 사용하여 특정 함수 연결 해제 가능
		logDelegate -= LogA; // 특정 함수 연결 해제
		logDelegate();
	} 

	private void LogA() 
	{ 
		Debug.Log("Log A");
	}
	private void LogB()
	{
		Debug.Log("Log B");
	}
}
