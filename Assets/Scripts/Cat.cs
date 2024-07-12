using System;
using UnityEngine;

public class Cat : Animal
{
  
  public Cat()
  {
    jumpMultiplier = 5;
  }

  protected override void Jump()
  {
    base.Jump();
  }

  protected override void Shout()
  {
    Debug.Log("MEOWWWWW");
  }
}
