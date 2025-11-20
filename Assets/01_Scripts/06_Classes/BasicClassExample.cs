using UnityEngine;

// 클래스 기본 정의, 오브젝트 생성을 위한 도면
public class BasicClass
{
	// 필드(Field) 
	public string name;
	public int id;
	int age; // 접근 제한자가 없으면 기본적으로 private

	// 생성자(Constructor) 정의
	// 생성자는 클래스 이름과 동일하며, 객체가 생성될 때 호출됨
	public BasicClass()
	{
		name = "DefaultName";
		id = 0;
		age = 0;
	}

	// 매개변수가 있는 생성자로 오버로딩
	public BasicClass(string name, int id, int age)
	{
		this.name = name; // this 키워드는 현재 객체를 가리킴
		this.id = id; // 매개변수와 필드 이름이 같을 때 구분하기 위해 사용
		this.age = age;
	}

	// 메서드(Method) 정의
	public void PrintStatus()
	{
		Debug.Log($"Name: {name}, ID: {id}, Age: {age}");
	}
}


public class BasicClassExample : MonoBehaviour // MonoBehaviour를 상속받아 유니티에서 사용할 수 있는 클래스는 생성자를 직접 호출하지 않음
{
	private void Start()
	{
		// 클래스 객체(오브젝트) 생성
		// 도면으로 만든 실제 제품
		BasicClass basicClass = new BasicClass(); // new 키워드를 사용하여 메모리에 할당

		basicClass.name = "ExampleName"; // 객채의 필드에 .을 사용하여 접근
		basicClass.id = 1;
		// basicClass.age = 25; // private 필드이므로 외부에서 접근 불가
		basicClass.PrintStatus(); // 클래스의 매서드 또한 .을 사용하여 접근

		// 생성자 사용
		BasicClass anotherClass = new BasicClass("AnotherName", 2, 30); // 생성자 사용시 private 필드도 초기화 가능
		anotherClass.PrintStatus();
	}
}

