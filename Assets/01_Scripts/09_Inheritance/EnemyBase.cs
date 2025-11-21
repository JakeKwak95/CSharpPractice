using UnityEngine;

// 적 클래스들의 공통 기능을 정의하는 추상(abstract) 클래스
// 추상 클래스는 인스턴스화할 수 없으며, 상속을 통해서만 사용할 수 있습니다.
public abstract class EnemyBase : MonoBehaviour
{
	// 접근 제한자(Access Modifiers) 예시
	int level = 1; // 기본 접근 제한자: 같은 클래스 내에서만 접근 가능
	public int hp; // public: 어디서든 접근 가능
	protected int attackPower; // protected: 서브 클래스에서 접근 가능

	public abstract void Init(); // 추상 메서드: 서브 클래스에서 반드시 구현해야 함
	protected virtual void Attack(EnemyBase enemy) // 보호된 메서드: 서브 클래스에서만 접근 가능
	{
		Debug.Log($"{name}: Attack {enemy.name}! Power: {attackPower}");
		enemy.TakeDamage(attackPower);
	}
	void TakeDamage(int amount) // 가상 메서드: 서브 클래스에서 재정의(오버라이드) 가능
	{
		hp -= amount;
		Debug.Log($"{name} TakeDamage! Amount: {amount} / Current HP: {hp}");

		if (hp <= 0)
		{
			Die();
		}
	}
	void Die() // 일반 메서드: 서브 클래스에서 접근 불가
	{
		Debug.Log($"{name} Die!");
	}
}
