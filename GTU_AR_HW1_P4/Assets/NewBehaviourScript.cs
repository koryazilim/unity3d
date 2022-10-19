using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
  
    public void loadScene1(){
      UnityEngine.SceneManagement.SceneManager.LoadScene("Scene1");
    }
    public void loadScene2(){
      UnityEngine.SceneManagement.SceneManager.LoadScene("Scene2");
    }
}
