using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCharacterController : CharacterController
{
  private int CoinsCount = 0;
  public GameManager GM;
  override protected void GetInput()
  {
    DirectionX = Input.GetAxis("Horizontal");
    DirectionY = Input.GetAxis("Jump");
  }
  override protected void Walk()
  {
    rigidBody.velocity = new Vector2(Speed * DirectionX, rigidBody.velocity.y);

  }

  override protected void Jump()
  {
    if (CanJump == true && DirectionY != 0)
    {
      rigidBody.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
      CanJump = false;
    }
  }

  override protected void Attack()
  {

  }

  protected override void Start()
  {
    base.Start();
    GM = new GameManager();
  }

  protected void OnTriggerEnter2D(Collider2D collider)
  {
    if (collider.gameObject.tag == "Coin")
    {
      Destroy(collider.gameObject);
      CoinsCount++;
    }

    if (collider.gameObject.tag == "KillBox")
    {
      GM.GameOver();
    }

    if (collider.gameObject.tag == "WinBox")
    {
      GM.Victory();
    }
  }

  public MainCharacterController() : base()
  {
    base.Speed = 4;
  }
}
