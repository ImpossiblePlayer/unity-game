using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacterController : CharacterController
{
  [SerializeField] private float AttackCooldown;
  private float CooldownTimer = Mathf.Infinity;

  override protected void GetInput()
  {

  }

  override protected void Attack()
  {

  }

  override protected void Walk()
  {

  }

  override protected void Jump()
  {

  }

  void Update()
  {

  }



  public EnemyCharacterController() : base() { }
}
