using UnityEngine;

public class Slime : EnemyBase
{
	// 다른 슬라임과 데미지를 나누기 위한 참조 변수
	// 적을 공격할 수있게 EnemyBase 을 사용한 Goblin 과 다르게 Slime 사용
	public Slime slimeToShareDamage;

	private void Start()
	{
		Init();
	}

	// override 키워드를 사용하여 추상 메서드 Init을 구현
	public override void Init()
	{
		attackPower = 0;
		Debug.Log($"{name}: 초기화! HP: {hp}, 공격력 : {attackPower}");
	}

	public override void TakeDamage(int amount)
	{
		// 다른 슬라임이 있으면 데미지를 반으로 나눔
		if (slimeToShareDamage)
		{
			amount /= 2; // 데미지를 반으로 나눔
			Debug.Log($"{name}이/가 {slimeToShareDamage.name}과/와 데미지를 나눕니다!");
			slimeToShareDamage.TakeDamage(amount); // 다른 슬라임도 데미지를 받음
		}

		base.TakeDamage(amount);
	}
}
