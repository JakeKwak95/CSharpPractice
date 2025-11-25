using UnityEngine;

// 유니티 6 이상 버젼에서 자동으로 추가
[CreateAssetMenu(fileName = "MovementDataSO", menuName = "Scriptable Objects/MovementDataSO")]
public class MovementDataSO : ScriptableObject
{
    public float moveSpeed = 2f;
    public float moveRange = 5f;
	public float rotateSpeed = 90f;
}

// ScriptableObject는 에셋으로 저장되며, 여러 오브젝트가 동일한 데이터를 공유할 수 있습니다.
// 이를 통해 메모리 사용량을 줄이고, 데이터 관리를 용이하게 할 수 있습니다.
// ScriptableObject를 사용하면 데이터 변경이 용이하며, 여러 오브젝트에 일괄 적용할 수 있어 유지보수가 편리합니다.
// 각 오브젝트, 프리펩마다 수정하는 것이 아닌 SO 데이터만 수정하면 되기 때문에 주후 밸런싱 작업에도 유리합니다.

// 또한, 런타임 시에 데이터를 동적으로 변경할 수도 있습니다.
// 예를 들어, 게임 내에서 난이도에 따라 움직임 속도를 조절할 수 있습니다.
// 이러한 유연성은 게임 개발에서 매우 유용합니다.

// 위 예제에서는 MovementDataSO를 사용하여 움직임과 회전 속도를 정의하고,
// MovingCubeWithSO 스크립트에서 이를 참조하여 움직임을 구현합니다.
// 반면, MovingCubeWithoutSO 스크립트는 각 오브젝트가 독립적으로 데이터를 가지므로,
// 많은 수의 오브젝트가 생성될 때 메모리 사용량이 증가할 수 있습니다.

