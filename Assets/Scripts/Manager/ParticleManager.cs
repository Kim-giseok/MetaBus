using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    static ParticleManager instance;
    public static ParticleManager Instance => instance;

    [SerializeField] ParticleSystem impactParticleSys;

    void Awake()
    {
        instance = this;
    }

    public void ParitclesAtPosition(Vector3 position)
    {
        impactParticleSys.transform.position = position;
        ParticleSystem.EmissionModule em = impactParticleSys.emission;
        em.SetBurst(0, new ParticleSystem.Burst(0, Mathf.Ceil(5)));
        ParticleSystem.MainModule mainModule = impactParticleSys.main;
        mainModule.startSpeedMultiplier = 10f;
        impactParticleSys.Play();
    }
}
