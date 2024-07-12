using System;
using UnityEngine;

public class Dog : Animal
{
  public Dog()
  {
    jumpMultiplier = 3;
  }

  protected override void Jump()
  {
    base.Jump();
  }

  protected override void Shout()
  {
    Debug.Log("WOOF!");
    base.Shout();
  }
}
