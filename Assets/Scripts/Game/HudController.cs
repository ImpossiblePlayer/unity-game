using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HudController : MonoBehaviour
{
  public Text CoinsCountText;
  public int CoinsCount;
  public GameManager GM;
  void Start()
  {
    // CoinsCountText = new Text(0);

    GM = FindObjectOfType<GameManager>();
  }


  void Update()
  {
    CoinsCountText.text = $"x {CoinsCount}";


  }
}
