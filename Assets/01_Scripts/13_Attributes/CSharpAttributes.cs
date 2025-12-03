using System;
using UnityEditor.PackageManager.UI;
using UnityEngine;

// 어트리뷰트(Attribute) : 클래스, 메서드, 속성 등에 추가적인 정보를 제공하는 메타데이터
// 코드에 "설명 + 동작"을 붙이는 기능
public class CSharpAttributes : MonoBehaviour
{
	// Serializable 어트리뷰트가 적용된 구조체 배열을 인스펙터에 노출
	public ExampleStruct[] examples;

	// Serializable 어트리뷰트가 적용된 클래스 인스턴스를 인스펙터에 노출
	public ExampleClass exampleClass;

	// Flags 어트리뷰트가 적용된 열거형 변수를 인스펙터에 노출
	public ExampleEnum exampleEnum;

	private void Start()
	{
		// Obsolete 어트리뷰트가 적용된 메서드 호출 (컴파일 시 취소선 및 경고 발생)
		ObsoleteMethod();
		NewMethod();
	}

	// Obsolete 어트리뷰트 : 더 이상 사용되지 않는 메서드임을 나타내며, 컴파일 시 경고 메시지를 출력
	// 하지만 여전히 호출은 가능
	[Obsolete("사용하지 않는 메서드 입니다. NewMethod() 를 사용하세요.")]
	void ObsoleteMethod()
	{
		Debug.Log("이 메서드는 더 이상 사용되지 않습니다.");
		foreach (var example in examples)
		{
			Debug.Log($"구조체 이름 : {example.name}, 값 : {example.value}");
		}
	}

	void NewMethod()
	{
		Debug.Log($"클래스 설명 : {exampleClass.description}, 값: {exampleClass.amount}");
		Debug.Log($"선택된 옵션 : {exampleEnum}");
	}
}

// System.Serializable : 구조체나 클래스를 인스펙터에 노출시키기 위해 사용
// Serialization : 직렬화, 데이터를 저장하거나 전송하기 위해 객체를 일련의 바이트로 변환하는 과정 (다른 프로그램이나 시스템에서 데이터를 읽고 쓸 수 있도록 함)
[Serializable]
public struct ExampleStruct
{
	public string name;
	public int value;
}

[Serializable]
public class ExampleClass
{
	public string description;
	public float amount;
}

// Flags 어트리뷰트 : 열거형이 비트 플래그로 사용될 수 있음을 나타내며, 비트 연산을 통해 여러 값을 조합할 수 있도록 함
[Flags]
public enum ExampleEnum
{
	FirstOption = 1 << 0,
	SecondOption = 1 << 1,
	ThirdOption = 1 << 2
}