using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
  protected Rigidbody rbAnimal;
  protected float jumpMultiplier = 1;

  public float JumpBase { get; set; }

  // Start is called before the first frame update
  void Start()
  {
    rbAnimal = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
  }

  private void OnMouseDown()
  {
    if (Input.GetMouseButtonDown(0))
    {
      this.Jump();
    }
    if (Input.GetMouseButtonDown(1))
    {
      this.Shout();
    }
  }

  protected virtual void Jump()
  {
    rbAnimal.AddForce(Vector3.up * this.JumpBase * jumpMultiplier);
    this.Shout();
  }

  protected virtual void Shout()
  {
  }

}
