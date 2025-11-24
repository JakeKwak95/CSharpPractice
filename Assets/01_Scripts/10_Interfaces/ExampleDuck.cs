using UnityEngine;

public class ExampleDuck : MonoBehaviour, ISwimable, IFlyable
{
    public void Swim()
    {
        Debug.Log($"{name} : 나 수영 할 수 있어!");
    }

    public void Fly()
    {
        Debug.Log($"{name} : 나 날 수 있어!");
	}
}
