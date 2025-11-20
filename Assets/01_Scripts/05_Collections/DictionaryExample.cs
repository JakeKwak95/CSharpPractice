using System.Collections.Generic;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{

	// 문자열을 키로, 정수를 값으로 갖는 빈 Dictionary 생성
	// 키는 중복 불가, 값은 중복 허용
	Dictionary<string, int> inventory = new Dictionary<string, int>();


	private void Start()
	{
		AddItemToInventory("Potion", 5);
		AddItemToInventory("Potion", 4);

		RemoveItemFromInventory("Potion", 3);
		RemoveItemFromInventory("Potion", 10);
		RemoveItemFromInventory("Potion", 1); 

		AddItemToInventory("Elixir", 2);

		foreach (var item in inventory)
		{
			Debug.Log($"인벤토리 아이템: {item.Key}, 수량: {item.Value}");
		}
	}

	private void AddItemToInventory(string itemName, int quantity)
	{
		if (inventory.ContainsKey(itemName))
		{
			inventory[itemName] += quantity;
			Debug.Log($"{itemName} 의 수량이 {quantity} 만큼 증가했습니다. 총 수량: {inventory[itemName]}");
		}
		else
		{
			inventory[itemName] = quantity;
			Debug.Log($"{itemName} 을(를) 새로 추가했습니다. 수량: {inventory[itemName]}");
		}
	}

	void RemoveItemFromInventory(string itemName, int quantity)
	{
		if (inventory.ContainsKey(itemName))
		{
			inventory[itemName] -= quantity;
			if (inventory[itemName] <= 0)
			{
				inventory.Remove(itemName);
				Debug.Log($"{itemName} 이(가) 인벤토리에서 제거되었습니다.");
			}
			else
			{
				Debug.Log($"{itemName} 의 수량이 {quantity} 만큼 감소했습니다. 남은 수량: {inventory[itemName]}");
			}
		}
		else
		{
			Debug.Log($"{itemName} 은(는) 인벤토리에 없습니다.");
		}
	}
}
