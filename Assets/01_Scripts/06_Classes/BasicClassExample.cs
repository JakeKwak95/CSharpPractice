using UnityEngine;

// 클래스 기본 정의, 오브젝트 생성을 위한 도면
public class BasicClass
{
	// 필드(Field) 
	public string name;
	public int id;

	// 생성자(Constructor) 정의
	// 생성자는 클래스 이름과 동일하며, 객체가 생성될 때 호출됨
	public BasicClass()
	{
		name = "DefaultName";
		id = 0;
	}

	// 매개변수가 있는 생성자로 오버로딩
	public BasicClass(string name, int id)
	{
		this.name = name; // this 키워드는 현재 객체를 가리킴
		this.id = id; // 매개변수와 필드 이름이 같을 때 구분하기 위해 사용
	}

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

		// 생성자 사용
		BasicClass anotherClass = new BasicClass("AnotherName", 2);
		anotherClass.PrintStatus();
	}
}

