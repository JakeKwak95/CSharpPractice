using UnityEngine;

public class ExampleEagle : MonoBehaviour, IFlyable
{
    public void Fly()
    {
        Debug.Log($"{name} : 나 날 수 있어!");
    }
}