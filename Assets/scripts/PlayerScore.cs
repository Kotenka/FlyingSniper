using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
	
	//private int playerLives;
	private int playerPoints;

	// используйте этот метод для инициализации
	void Start()
	{
		// получим начальную позицию платформы
		//playerPosition = gameObject.transform.position;

		//playerLives = 3;
		playerPoints = 0;

	}
	void addPoints(int points)
	{
		playerPoints += points;
	}
	void OnGUI()
	{
		GUI.Label(new Rect(5.0f, 3.0f, 500.0f, 500.0f), "  Score: " + playerPoints);
	}
}
