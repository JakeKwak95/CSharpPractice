using UnityEngine;

// 순서 : 읽기전용 프로퍼티 -> 경험치 증가 및 레벨업 -> Hp 감소 및 범위 제한 -> 읽기전용 hp 퍼센트 프로퍼티
public class PropertyUsage : MonoBehaviour
{
	// 사용법 1: 읽기 전용 프로퍼티 - 다른 클래스에서 값을 읽을 수는 있지만, 변경하지 못하도록 할 때
	public int Level { get; private set; } = 1;
	public PropertyUsage otherExample;

	// 사용법 2: 유효성 검사 포함 프로퍼티 - 값을 설정할 때 특정 조건을 만족하는지 확인하고 싶을 때
	int experience;
	public int Experience
	{
		get => experience;
		set
		{
			experience = value;
			CheckLevelUp();
		}
	}

	int hp = 100;
	public int Hp
	{
		get => hp;
		set
		{
			if (value < 0)
				hp = 0;
			else if (value > 100)
				hp = 100;
			else
				hp = value;

			Debug.Log($"현재 Hp: {hp}");
		}
	}

	// 사용법 3: 계산된 값 반환 프로퍼티 - 필드 값을 기반으로 계산된 값을 반환하고 싶을 때
	int maxHp = 100;
	public float HpPercentage
	{
		get => (hp / (float)maxHp) * 100f; // Hp의 백분율 계산(int 끼리의 나눗셈 방지 위해 float로 캐스팅)
	}

	private void Start()
	{
		// int level = otherExample.Level; // 다른 클래스에서 프로퍼티 값 읽기 가능
		// otherExample.Level = 5; // 오류 발생: set 접근자가 private이기 때문
	}

	private void Update()
	{
		Experience++;
		Hp -= Level;
	}

	private void CheckLevelUp()
	{
		if (Experience >= Level * 100)
		{
			Level++;
			Experience = 0;
			Debug.Log($"레벨업! 현재 레벨: {Level}");
		}
	}
}
