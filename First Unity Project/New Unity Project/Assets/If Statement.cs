using UnityEngine;
using System.Collections;

public class IfStatement : MonoBehaviour

{
	float HotChocolateTemperature = 80.0f;
	float hotLimitTemperature = 85.0f;
	float coldLimitTemperature = 50.0f;

	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		HotChocolateTemperature -= Time.deltaTime * 5f;
	}
	void TemperatureTest ()
	{
		if(HotChocolateTemperature > hotLimitTemperature)
		{
			print("Hot Chocolate is too hot.");
		}
		else if(HotChocolateTemperature < coldLimitTemperature)
		{
			print("Hot Chocolate is too cold.");
		}
		else
		{
			print("Hot Chocolate is just right.");
		}
	}
}