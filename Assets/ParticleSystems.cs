using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class ParticleSystems : MonoBehaviour
{

    ParticleSystem ps;
    


    private void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    public void OnSpray(InputAction.CallbackContext context)
    {
        ps.Emit(50);
    }


    /*public void Spray2(InputAction.CallbackContext context)
    {
        ps.Emit(100);
    }

    public void Spray3(InputAction.CallbackContext context)
    {
        ps.Emit(40);
    }
    public void Spray4(InputAction.CallbackContext context)
    {
        ps.Emit(90);
    */
}

  

