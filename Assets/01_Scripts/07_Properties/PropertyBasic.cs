using UnityEngine;

public class PropertyBasic : MonoBehaviour
{
	// 프로퍼티 예제
	// 프로퍼티 사용 이유 : 필드에 대한 접근 제어, 유효성 검사, 계산된 값 반환 등 다양한 기능을 제공

	// 가장 기본적인 형태
	int hp;
	public int Hp
	{
		get
		{
			//Hp 값을 반환
			return hp;
		}
		set
		{
			//Hp 값을 설정
			hp = value;
		}
	}

	int mp;
	public int Mp // 또는 한 줄로 { get => mp; set => mp = value; }
	{
		get => mp; // 표현식 본문으로 간단히 작성
		set => mp = value;
	}

	int Exp { get; set; } // 자동 구현 프로퍼티

	// 위 3가지 형태 모두 동일한 기능을 수행

	private void Start()
	{
		Hp = 100; // set 접근자 사용
		Debug.Log($"현재 Hp: {Hp}"); // get 접근자 사용

		Mp = 50;
		Debug.Log($"현재 Mp: {Mp}");

		Exp = 200;
		Debug.Log($"현재 Exp: {Exp}");
	}
}
