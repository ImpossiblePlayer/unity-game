using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuController : MonoBehaviour
{

  public void Replay()
  {
    FindObjectOfType<GameManager>().StartGame();
  }

  public void OpenMainMenu()
  {
    FindObjectOfType<GameManager>().OpenMainMenu();
  }
}
