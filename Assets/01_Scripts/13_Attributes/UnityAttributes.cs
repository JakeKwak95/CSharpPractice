using UnityEngine;

// 하나의 게임 오브젝트에 중복된 컴포넌트가 추가되지 않도록 제한
[DisallowMultipleComponent]

// 해당 컴포넌트가 추가된 게임 오브젝트에 특정 컴포넌트가 반드시 존재하도록 요구
[RequireComponent(typeof(Rigidbody))]

// 프리펩 편집 모드와 에딧 모드 모두에서 스크립트가 실행되도록 함
[ExecuteAlways]

// 에딧 모드에서 스크립트가 실행되도록 함
[ExecuteInEditMode]

// 스크립트의 실행 순서를 지정
// Edit/Project Settings/Script Execution Order에서 확인 가능
// 숫자가 작을수록 먼저 실행됨
[DefaultExecutionOrder(-10)]
public class UnityAttributes : MonoBehaviour
{
	// Inspector에서 변수 그룹화
	[Header("Player Settings")]
	// Inspector에서 private 변수를 직렬화하여 노출, 보통 타 클래스에서 접근 불가능한 변수들을 인스펙터에서 조절하고자 할 때 사용
	[SerializeField] private float moveSpeed = 5f;

	// Inspector에서 변수의 최소/최대 값을 제한, 슬라이더로 조절 가능
	[Range(1, 100)]
	[SerializeField] int health = 50;

	// Inspector에서 변수에 대한 설명 추가, 마우스 오버 시 툴팁 표시
	[Tooltip("플레이어의 이름입니다.")]
	[SerializeField] string playerName;

	// Inspector에서 여러 줄의 텍스트 입력 가능
	// 첫번째 매개변수는 최소 줄 수, 두번째 매개변수는 최대 줄 수
	[TextArea(3, 10)]
	[SerializeField] string textAreaWithLimits;

	// 기본값은 3,3
	[TextArea]
	[SerializeField] string textArea;

	// Inspector에서 변수 간격 추가
	[Space(10)]

	// Inspector에서 변수의 최소 값 제한
	[Min(0)]
	[SerializeField] float stamina = 10f;

	// Inspector에서 열거형을 버튼 형태로 표시
	[EnumButtons] public ExampleEnum exampleEnum;

	// Inspector에서 변수 숨기기
	[HideInInspector] public float hiddenVariable = 100f;

	// 프로퍼티를 인스펙터에 노출하기 위해 사용
	// 여러 어트리뷰트를 조합하여 사용 가능(한 중괄호 안에 여러 개 작성 가능)
	[field: SerializeField, Range(0,10)] public int SomeProperty { get; private set; } = 10;

	private void Update()
	{
		// 플레이 중이 아니더라도 실행되도록 어트리뷰트로 설정됨
		Debug.Log(exampleEnum);
	}

	// Inspector에서 실행 가능한 함수 만들기
	// 우클릭 컨텍스트 메뉴에 나타남
	// 메서드를 테스트 할 때 유용
	[ContextMenu("Reset Player Settings")]
	private void ResetSettings()
	{
		moveSpeed = 5f;
		health = 50;
		stamina = 10f;
		Debug.Log("플레이어 설정 초기화 완료!");
	}
}
