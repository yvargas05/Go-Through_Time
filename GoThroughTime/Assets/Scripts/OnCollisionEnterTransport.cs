using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollisionEnterTransport : MonoBehaviour{

      public string NextLevel = "MainMenu";

      public void OnCollisionEnter(Collision other){
            if (other.gameObject.tag == "Player"){
                  SceneManager.LoadScene (NextLevel);
            }
      }

}