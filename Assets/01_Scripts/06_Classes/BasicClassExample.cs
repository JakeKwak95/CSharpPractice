using UnityEngine;

// 클래스 기본 정의, 오브젝트 생성을 위한 도면
public class BasicClass
{
	// 필드(Field) 
	public string name;
	public int id;

	// 메서드(Method) 정의
	public void PrintStatus()
	{
		Debug.Log("Name: " + name + ", ID: " + id);
	}
}


public class BasicClassExample : MonoBehaviour
{
	private void Start()
	{
		// 클래스 객체(오브젝트) 생성
		// 도면으로 만든 실제 제품
		BasicClass basicClass = new BasicClass(); // new 키워드를 사용하여 메모리에 할당

		basicClass.name = "ExampleName"; // 객채의 필드에 .을 사용하여 접근
		basicClass.id = 1;
		basicClass.PrintStatus(); // 클래스의 매서드 또한 .을 사용하여 접근
	}
}

