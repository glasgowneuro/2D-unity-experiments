using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Text scoreText;
	private int score;
	private bool gameOver = false;
	void Start(){
		score = 0;
		InvokeRepeating ("UpdateScore", 1f, 1f);
	}

	void Update(){
		scoreText.text = "Score: " + score + " m";
	}
	void UpdateScore(){
		if (!gameOver) {
			score += 1;
		}
	}

	public void LoadLevel(string level){
		UnityEngine.SceneManagement.SceneManager.LoadScene (level);
	}
	public void LoadNextLevel(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex + 1);
	}
	public void ResetLevel(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex);
	}
	public void Exit(){
		Application.Quit();
	}
}
