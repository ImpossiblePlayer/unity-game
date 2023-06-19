
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
  // Start is called before the first frame update
  public TextMeshProUGUI StartButton;
  public Button ExitButton;
  void Start()
  {
    // StartButton = transform.GetChild(0).GetComponent<Button>();
    // StartButton.onClick.AddListener(StartGame);

  }

  void Update()
  {

  }

  public void StartGame()
  {
    FindObjectOfType<GameManager>().StartGame();
  }

  public void ExitGame()
  {
    FindObjectOfType<GameManager>().Quit();
  }

}
