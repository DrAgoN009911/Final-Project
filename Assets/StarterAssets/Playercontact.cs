using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playercontact : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Cube (1)")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
       else if (other.gameObject.tag == "Cube (2)")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
      else if (other.gameObject.tag == "Cube (3)")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

}
