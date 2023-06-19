using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public MainCharacterController Player;
  private Vector2 PlayerStartPosition;

  void Start()
  {

  }

  public void StartGame()
  {
    SceneManager.LoadScene("Game");
    PlayerStartPosition = Player.transform.position;
  }

  public void Victory()
  {
    SceneManager.LoadScene("Victory");
  }
  public void GameOver()
  {
    SceneManager.LoadScene("GameOver");
  }

  public void Quit()
  {

    Application.Quit();
  }

  public void OpenMainMenu()
  {
    SceneManager.LoadScene("Menu");
  }
}
