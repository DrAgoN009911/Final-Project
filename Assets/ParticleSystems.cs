using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class ParticleSystems : MonoBehaviour
{

    ParticleSystem ps;
    ParticleSystem ps1;
    ParticleSystem ps2;
    ParticleSystem ps3;
    ParticleSystem ps4;



    private void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps1 = GetComponent<ParticleSystem>();
        ps2 = GetComponent<ParticleSystem>();
        ps3 = GetComponent<ParticleSystem>();
        ps4 = GetComponent<ParticleSystem>();
        

    }

    public void OnSpray(InputAction.CallbackContext context)
    {
        ps.Emit(50);
    }

    public void OnSpray2(InputAction.CallbackContext context)
    {
        ps1.Emit(100);
    }

    public void OnSpray3(InputAction.CallbackContext context)
    {
        ps2.Emit(40);
    }
    public void OnSpray4(InputAction.CallbackContext context)
    {
        ps3.Emit(90);
    }
    public void OnSpray5(InputAction.CallbackContext context)
    {
        ps4.Emit(200);
    }
}
  

