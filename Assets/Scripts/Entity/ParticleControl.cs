using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{
    [SerializeField] private bool createDustOnWalk = true;
    [SerializeField] private ParticleSystem ParticleSys;

    public void CreateDustParticles()
    {
        if (createDustOnWalk)
        {
            ParticleSys.Stop();
            ParticleSys.Play();
        }
    }

    public void ParitclesAtPosition(Vector3 position)
    {
        ParticleSys.transform.position = position;

        ParticleSystem.EmissionModule em = ParticleSys.emission;
        em.SetBurst(0, new ParticleSystem.Burst(0, Mathf.Ceil(5)));

        ParticleSystem.MainModule mainModule = ParticleSys.main;
        mainModule.startSpeedMultiplier = 10f;

        ParticleSys.Play();
    }
}
