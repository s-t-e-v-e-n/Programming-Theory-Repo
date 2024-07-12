using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{

  public void StartNew()
  {
    SceneManager.LoadScene(1);
  }

}
