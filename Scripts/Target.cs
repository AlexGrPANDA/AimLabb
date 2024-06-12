//Target - Prefab Script for Target Objects which spawn in the targetboundary
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Target : MonoBehaviour, IDamageable
{

    public float health = 1f;

    public void TakeDamage(float damage)
    {
        Debug.Log("Target Hit");

        transform.position = TargetBoundary.Instance.GetRandomPos();
    }
}
