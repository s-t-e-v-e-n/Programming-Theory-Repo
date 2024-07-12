using System;
using UnityEngine;
public class Elephant : Animal
{
  public Elephant()
  {
  }

  protected override void Jump()
  {
    base.Jump();
  }

  protected override void Shout()
  {
    Debug.Log("ELEPHANT NOISES!");
  }
}
