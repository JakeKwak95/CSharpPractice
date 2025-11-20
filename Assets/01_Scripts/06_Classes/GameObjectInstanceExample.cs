using UnityEngine;

// 도면인 클라스 생성
public class GameObjectInstanceExample : MonoBehaviour
{
	public string objectName; // 오브젝트의 이름을 저장하는 필드
	public GameObjectInstanceExample otherGameObject; // 다른 오브젝트를 참조하는 필드

	private void Start()
	{
		SayHi();
	}

	public void SayHi()
	{
		// 다른 오브젝트가 참조되어 있다면 인사 메시지 출력
		if (otherGameObject != null)
			Debug.Log($"{objectName}: 안녕! {otherGameObject.objectName}. 좋은 하루 보내!!");
	}
}


