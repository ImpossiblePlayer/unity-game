using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class CharacterController : MonoBehaviour
{
  [SerializeField] protected int Speed = 4;
  [SerializeField] protected float JumpPower = 7f;
  [SerializeField] protected float DirectionX, DirectionY = 0;
  public bool CanJump = true;
  [SerializeField] protected float RayDistance = 1.2f;
  [SerializeField] protected int HealthPoints = 20;
  [SerializeField] protected int Damage;

  protected SpriteRenderer spriteRenderer;
  protected Rigidbody2D rigidBody;
  protected BoxCollider2D boxCollider;
  protected Transform transform;

  protected virtual void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
    rigidBody = GetComponent<Rigidbody2D>();
    boxCollider = GetComponent<BoxCollider2D>();
    transform = GetComponent<Transform>();
  }

  // Update is called 30 times a second
  void FixedUpdate()
  {
    // isOnLadders();
    GetInput();
    Jump();
    Walk();
  }

  void Update()
  {
    Flip();
    Attack();
  }

  protected abstract void GetInput();
  protected abstract void Walk();
  protected abstract void Jump();
  protected abstract void Attack();
  protected virtual void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Ground") CanJump = true;
  }
  // protected virtual void OnCollisionStay2D(Collision2D collision)
  // {
  //   if (collision.gameObject.tag == "Ground") CanJump = true;
  // }
  protected virtual void OnCollisionExit2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Ground") CanJump = false;
  }
  void isOnLadders()
  {
    // RaycastHit2D ladderHit = Physics2D.Raycast(rigidBody.position, Vector2.down, 0.1f, LayerMask.GetMask("Ladders"));

    // if (ladderHit.collider)
    // {
    //   CanJump = false;
    //   DirectionY = Input.GetAxis("Vertical");
    //   if (DirectionY > 0)
    //   {
    //     rigidBody.AddForce(Vector2.up * 0.04f, ForceMode2D.Impulse);
    //   }
    // }
    // else
    // {
    //   CanJump = true;
    //   DirectionY = 0;
    // }
  }

  void Flip()
  {
    if (DirectionX > 0) spriteRenderer.flipX = false;
    if (DirectionX < 0) spriteRenderer.flipX = true;
  }
}
