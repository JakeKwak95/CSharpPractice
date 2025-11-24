using UnityEngine;

// 모든 새 클래스의 공통 기능을 정의하는 추상 클래스

// 클래스 상속은 is a 관계를 나타낼 때 사용
// 예: 오리는 새다. 독수리는 새다. 펭귄은 새다.
// 인터페이스 구현은 can do 관계, 또는 has a 관계를 나타낼 때 사용
// 예: 오리는 수영할 수 있다. 독수리는 날 수 있다. 펭귄은 수영할 수 있다.
public abstract class ExampleBirdBase : MonoBehaviour
{
    // 서브 클래스 에서 구현 후 호출
    protected abstract void Eat();

    // 서브 클래스에서 구현 후 타 클래스에서 호출 가능
    public abstract void IntroduceYourSelf();
}
