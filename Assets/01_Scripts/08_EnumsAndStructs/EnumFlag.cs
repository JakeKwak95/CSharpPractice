using UnityEngine;

// 플래그 열거형은 비트 연산을 사용하여 여러 상태를 동시에 표현할 수 있습니다.
[System.Flags] // Flags 어트리뷰트를 추가하여 플래그 열거형임을 명시합니다.
public enum Buffs
{
	None = 0,

	// 쉬프트 연산자(<<)를 사용하여 각 값이 2의 거듭제곱이 되도록 설정합니다.
	// << : 비트 단위로 왼쪽으로 이동시키는 연산자입니다.

	Strength = 1 << 0,       // 0001
	Agility = 1 << 1,        // 0010
	Intelligence = 1 << 2,   // 0100
	Stamina = 1 << 3,        // 1000
	All = Strength | Agility | Intelligence | Stamina // 1111
}

public class EnumFlag : MonoBehaviour
{
	// 플래그 열거형은 한번에 여러 값을 가질 수 있습니다.
	// 인스펙터에서는 드롭다운 중 여러 개를 선택할 수 있는 형태로 표시됩니다.
	public Buffs currentBuffs = Buffs.None;

	void Start()
	{
		// 처음에는 아무 버프도 없음
		currentBuffs = Buffs.None;

		// 비트 연산 OR 연산자를 사용하여 버프 추가
		// OR(|) : 비트 단위로 두 값을 비교하여 하나라도 1인 경우 1을 반환합니다.

		currentBuffs = currentBuffs | Buffs.Strength | Buffs.Agility;
		// currentBuffs 0000
		// Strength     0001
		// Agility      0010
		// OR           0011
		Debug.Log("Strength와 Agility 버프 추가");
		Debug.Log($"현재 버프: {currentBuffs}");

		// 비트 연산으로 인해 currentBuffs는 Strength와 Agility 버프를 동시에 가집니다.

		// HasFlag 함수를 사용하여 특정 버프가 있는지 확인
		bool hasStrength = currentBuffs.HasFlag(Buffs.Strength);
		bool hasIntelligence = currentBuffs.HasFlag(Buffs.Intelligence);
		Debug.Log($"힘 버프 : {hasStrength}");
		Debug.Log($"지능 버프 : {hasIntelligence}");

		// 비트 연산 NOT 연산자와 AND 연산자를 사용하여 버프 제거
		// NOT(~) : 비트 단위로 값을 반전시킵니다. 0은 1로, 1은 0으로 바뀝니다.
		// AND(&) : 비트 단위로 두 값을 비교하여 둘 다 1인 경우에만 1을 반환합니다.

		currentBuffs = currentBuffs & ~Buffs.Agility;
		// currentBuffs 0011
		// ~Agility     1101
		// AND          0001
		Debug.Log("Agility 버프 제거");
		Debug.Log($"현재 버프: {currentBuffs}");

		// 비트 연산 XOR 연산자를 사용하여 버프 토글
		// XOR(^) : 비트 단위로 두 값을 비교하여 서로 다를 때 1을 반환합니다.

		currentBuffs = currentBuffs ^ Buffs.Stamina;
		// currentBuffs 0001
		// Stamina      1000
		// XOR          1001

		Debug.Log("Stamina 버프 토글");
		Debug.Log($"현재 버프: {currentBuffs}");

		currentBuffs = currentBuffs ^ Buffs.Stamina;
		// currentBuffs 1001
		// Stamina      1000
		// XOR          0001

		Debug.Log("Stamina 버프 토글");
		Debug.Log($"현재 버프: {currentBuffs}");
	}

}
