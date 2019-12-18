using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AuraAPI;

[RequireComponent(typeof(AuraLight))]
public class AuraController : MonoBehaviour
{
    [SerializeField]
    private AuraLight light;

    [SerializeField]
    private AnimationCurve lightCurve;

    [SerializeField]
    private float runRatio;

    [SerializeField]
    private Vector2 MinMax;

    void Update()
    {
        light.strength = Mathf.Lerp(MinMax.x, MinMax.y, lightCurve.Evaluate(Mathf.Repeat(Time.time * runRatio, 1)));
    }
}
