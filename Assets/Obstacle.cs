using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform SpawnPoint;
    
    void OnCollisionEnter (Collision coll)
    { 
    if (coll.gameObject.tag == "Player")
        
    {
            Player.transform.position = SpawnPoint.transform.position;
        }
    }

}

