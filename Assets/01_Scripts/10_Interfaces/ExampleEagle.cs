using UnityEngine;

/*public class ExampleEagle : MonoBehaviour, IFlyable
{
    public void Fly()
    {
        Debug.Log($"{name} : 나 날 수 있어!");
    }
}*/

public class ExampleEagle : ExampleBirdBase, IFlyable
{
	protected override void Eat()
	{
		Debug.Log($"{name} : 쥐를 먹어!");
	}

	public override void IntroduceYourSelf()
	{
		Eat();
		Fly();
	}

	public void Fly()
    {
        Debug.Log($"{name} : 나 날 수 있어!");
    }
}