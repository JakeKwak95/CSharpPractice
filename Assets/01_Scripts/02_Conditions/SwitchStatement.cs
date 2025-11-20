using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
	public string weapon = "Sword";

	// 여러 조건을 비교할 때 가독성이 좋은 switch 문 예제

	private void Update()
	{
		// 무기 종류에 따라 다른 메시지 출력
		switch (weapon) // switch 옆 괄호 안에는 비교할 변수를 넣습니다.
		{
			// case 뒤에는 비교할 값들을 넣습니다.
			case "Sword":
				// 해당 case에 맞으면 실행할 코드
				Debug.Log("칼을 장착했습니다. 근접 공격 가능!");
				// break 문을 만나면 switch 문을 빠져나갑니다.
				break;

			case "Bow":
				Debug.Log("활을 장착했습니다. 원거리 공격 가능!");
				break;

			case "Staff":
				Debug.Log("지팡이를 장착했습니다. 마법 공격 가능!");
				break;

			// default는 위의 case들에 해당하지 않는 모든 경우에 실행됩니다.
			default:
				Debug.LogWarning("알 수 없는 무기입니다.");
				break;
		}

		// string 대신 int, char, enum 등 다양한 타입을 사용할 수 있습니다.
		// Tip : char, string 타입은 대소문자를 구분합니다.
	}
}
