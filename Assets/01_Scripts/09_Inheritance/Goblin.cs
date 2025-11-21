using UnityEngine;

public class Goblin : EnemyBase
{
	public EnemyBase otherEnemyToAttack; // 다른 적을 공격하기 위한 참조 변수

	private void Start()
	{
		Init();
		Attack(otherEnemyToAttack); // 다른 적을 공격
	}

	// override 키워드를 사용하여 추상 메서드 Init을 구현

	public override void Init()
	{
		attackPower = 15;
		Debug.Log($"{name} Goblin Initialized! HP: {hp}, Attack Power: {attackPower}");
	}

	// override 키워드를 사용하여 보호된 메서드 Attack을 재정의
	protected override void Attack(EnemyBase enemy)
	{
		if (!enemy) return; // ()괄호 안에 참조 변수를 넣어 null 체크

		Debug.Log($"{name} Goblin is attacking!");
		base.Attack(enemy); // base : 부모 클래스
							// 부모 클래스의 Attack 메서드 호출
	}
}