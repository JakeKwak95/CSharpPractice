using UnityEngine;

/// <summary>
/// 기본적인 C# 스크립트 구조를 설명하기 위한 예제.
/// 클래스, 변수, 메서드, 주석, 상속의 형태를 보여줍니다.
/// </summary>
public class ScriptStructure : MonoBehaviour // MonoBehaviour를 상속받아 Unity 컴포넌트로 사용
{
	// 1. 필드(변수)
	public int health = 100;       // 공개 변수 (Inspector에서 보임)
	private float speed = 5f;      // 비공개 변수 (스크립트 내부에서만 사용)

	// 2. Unity 생명주기 함수
	void Start()
	{
		Debug.Log("ScriptStructure 시작!");
		Debug.Log("현재 체력: " + health);
	}

	void Update()
	{
		// 매 프레임마다 속도를 이용해 오른쪽으로 이동
		// 덧셈 연산자(+=) 사용 예시
		transform.position += Vector3.right * speed * Time.deltaTime;

		TakeDamage(1); // 매 프레임마다 1의 데미지를 받음

		// 조건문 예시
		if (health <= 0)
		{
			Debug.Log("플레이어가 사망했습니다.");
			// 게임 오버 처리 로직 추가 가능

			Heal(100); // 예시로 체력 회복 메서드 호출
		}
	}

	// 3. 일반 메서드 정의
	void TakeDamage(int damage)
	{
		health -= damage;
		Debug.Log("데미지를 받았습니다! 남은 체력: " + health);
	}

	// 4. 주석 예시 메서드
	/// <summary>
	/// 플레이어의 체력을 특정 수치로 회복시키는 메서드
	/// </summary>
	/// <param name="amount"></param>
	public void Heal(int amount)
	{
		health += amount;
		Debug.Log("체력이 회복되었습니다! 현재 체력: " + health);
	}
}
