using System.Security.Principal;
using Unity.VisualScripting;
using UnityEngine;


public class ClassVsStruct : MonoBehaviour // 클래스는 다른 클래스를 상속할 수 있습니다. 구조체(struct)는 상속할 수 없습니다.
										   // 인터페이스는 클래스와 구조체 모두 구현할 수 있습니다.
{
	// 참조 타입 vs 값 타입
	// 참조 타입은 힙(Heap) 메모리에 저장되고, 값 타입은 스택(Stack) 메모리에 저장됩니다. 
	// 참조 타입은 변수에 실제 데이터가 아닌 데이터의 "참조"를 저장하며, 값 타입은 변수에 실제 데이터를 저장합니다.

	// 클래스 : 참조 타입
	public class PlayerClass
	{
		public int hp;

		public PlayerClass(int hp)
		{
			this.hp = hp;
		}
	}

	// 스트럭트 : 값 타입
	public struct PlayerStruct
	{
		public int hp;

		public PlayerStruct(int hp)
		{
			this.hp = hp;
		}
	}

	private void Start()
	{
		PlayerClass classA = new PlayerClass(100);
		// 참조 복사: classA와 classB는 동일한 객체를 참조
		PlayerClass classB = classA; // "참조"를 복사

		Debug.Log($"[Class] A.hp = {classA.hp}"); // 100
		Debug.Log($"[Class] B.hp = {classB.hp}"); // 100

		classB.hp = 50; // classB 변경 -> classA도 변경됨
		Debug.Log($"classB.hp를 50으로 변경했습니다.");

		Debug.Log($"[Class] A.hp = {classA.hp}"); // 50
		Debug.Log($"[Class] B.hp = {classB.hp}"); // 50


		// STRUCT TEST
		PlayerStruct structA = new PlayerStruct(100);
		PlayerStruct structB = structA; // 값만 복사

		Debug.Log($"[Struct] A.hp = {structA.hp}"); // 100
		Debug.Log($"[Struct] B.hp = {structB.hp}"); // 100

		structB.hp = 50; // structB 변경 -> structA는 변경되지 않음
		Debug.Log($"structB.hp를 50으로 변경했습니다.");

		Debug.Log($"[Struct] A.hp = {structA.hp}"); // 100
		Debug.Log($"[Struct] B.hp = {structB.hp}"); // 50

		// class 를 쓰는 이유 :
		// 객체의 정체성(identity)이 중요할 때(같은 인스턴스를 여러 곳에서 공유하고 변경을 반영해야 할 때).
		// 상속이 필요할 때.
		// 크기가 크고 복사 비용이 큰 데이터를 다룰 때(복사 비용 회피).

		// struct 를 쓰는 이유 :
		// 성능 최적화가 필요할 때(특히 대량의 작은 데이터 객체를 다룰 때).
	}
}
