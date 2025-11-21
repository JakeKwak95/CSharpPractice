using System;
using UnityEngine;

// 구조체(Struct)란 데이터를 묶어서 하나의 단위로 표현하는 사용자 정의 형식입니다.

[Serializable] // 구조체를 인스펙터에 표시하려면 Serializable 어트리뷰트를 추가해야 합니다.
public struct PlayerInfo
{
    public string playerName;
    public StateExample state;
    public Buffs buffs;

	// 생성자(Constructor)
	public PlayerInfo(string name, StateExample state, Buffs buffs)
    {
        playerName = name;
        this.state = state;
        this.buffs = buffs;
        Debug.Log("PlayerInfo 구조체가 생성되었습니다.");
	}

    // 메서드(Method)
    public void DisplayInfo()
    {
        Debug.Log($"Player Name: {playerName}, State: {state}, Buffs: {buffs}");
    }
}

public class StructBasic : MonoBehaviour
{
	// struct에 [Serializable] 어트리뷰트를 추가해줬기 때문에 인스펙터에 구조체가 표시됩니다.
	public PlayerInfo info;

	// 자주 쓰이는 구조체 예시
	public Vector3 vector3; // 3가지 float 값을 가지는 형식의 구조체
    public Color color;     // 4가지 float 값을 가지는 형식의 구조체로 색상을 표현

	void Start()
    {
        info.DisplayInfo();
        info = new PlayerInfo("Player1", StateExample.Idle, Buffs.Strength | Buffs.Agility);
        info.DisplayInfo();
    }   
}
