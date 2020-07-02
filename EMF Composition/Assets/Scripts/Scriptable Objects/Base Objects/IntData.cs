using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject {
	public int value = 0;

	public void SetValue(int number)
	{
		value = number;
	}

	public void IncrementValue()
	{
		value++;
	}

	public void DecrementValue()
	{
		value--;
	}

	public void AddValue(int number)
	{
		value += number;
	}

	public void SubtractValue(int number)
	{
		value -= number;
	}

}
