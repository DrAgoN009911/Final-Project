
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SprayParticlesFromTransform : MonoBehaviour
{
    UnityEngine.ParticleSystem ps;
	ParticleSystemRenderer psr;

	public UnityEngine.ParticleSystem.EmissionModule emission;
	public UnityEngine.ParticleSystem.TrailModule trail;
	public UnityEngine.ParticleSystem.MainModule main;
	public UnityEngine.ParticleSystem.ShapeModule shape;
	public UnityEngine.ParticleSystem.SubEmittersModule subEmitters;
	public UnityEngine.ParticleSystem.LightsModule lights;
	public UnityEngine.ParticleSystem.Particle particle;
	public UnityEngine.ParticleSystem.CollisionModule collision;
	public UnityEngine.ParticleSystem.TextureSheetAnimationModule textureSheet;


	public Transform trackedObject;
	public float sprayAmount = 3;

	private AnimationCurve curve = new AnimationCurve();


	public bool spray; // Sets emission rate over time. 
	public bool trails; // Sets emission rate over time. 
	public bool widthOverTrail = true;

	void Update()
	{


		if (trackedObject != null)
		{
			shape.position = trackedObject.position;
		}

		if(trails)
        {
			trail.ratio = 0.5f;
            trail.widthOverTrail = new UnityEngine.ParticleSystem.MinMaxCurve(0.01f, 1.0f);
		}
        else
        {
			trail.ratio = 0f;
		}

		if (widthOverTrail)
            trail.widthOverTrail = new UnityEngine.ParticleSystem.MinMaxCurve(1.0f, curve);
		else
			trail.widthOverTrail = 1.0f;



		if (spray)
		{
			emission.enabled = true;
			emission.rateOverTime = sprayAmount;
			trail.enabled = true; 
			this.GetComponent<AudioSource>().volume = 1;
		}
		else
		{
			emission.rateOverTime = 0;
			this.GetComponent<AudioSource>().volume = 0;
		}
	}

	private void Start()
	{
        ps = GetComponent<UnityEngine.ParticleSystem>();
		psr = ps.GetComponent<ParticleSystemRenderer>();
		psr.trailMaterial = new Material(Shader.Find("Sprites/Default"));



		emission = ps.emission;
		trail = ps.trails;
		main = ps.main;
		shape = ps.shape;
		subEmitters = ps.subEmitters;
		lights = ps.lights;
		collision = ps.collision;
		textureSheet = ps.textureSheetAnimation;

		
		psr.material.color = Color.blue;


        main.startColor = new UnityEngine.ParticleSystem.MinMaxGradient(new Color(0f,  1f, 1f, 1));

		curve.AddKey(0.0f, 1.0f);
		curve.AddKey(1.0f, 0.0f);
	}

	private void OnDisable()
	{

	}



}