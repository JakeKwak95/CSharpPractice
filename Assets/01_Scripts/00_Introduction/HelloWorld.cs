using UnityEngine;

public class HelloWorld : MonoBehaviour
{
	// Unity가 게임 시작 시 자동으로 호출하는 메서드
	void Start()
	{
		Debug.Log("Hello World!");
		Debug.Log("게임이 시작되었습니다.");
	}

	// 매 프레임마다 호출되는 메서드
	void Update()
	{
		Debug.Log("프레임이 갱신 중입니다...");
	}
}
