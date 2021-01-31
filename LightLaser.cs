using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightLaser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10.0f;
    private float lifeTime = 1f;
    private bool lightExpanded;

    void Update()
    {
        LightLifetime();
        StartCoroutine(Movement());
        StartCoroutine(LightPulse());
    }

    private void LightLifetime()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator Movement()
    {
        ForwardMovement();
        yield return new WaitForSeconds(.25f);
        BackwardMovement();

    }

    private void ForwardMovement()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
    }

    private void BackwardMovement()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }


    IEnumerator LightPulse()
    {
        ExpandLightRangeAndIntensity();
        yield return new WaitForSeconds(.5f);
        lightExpanded = true;
        RetractLightRangeAndIntensity();
    }

    private void ExpandLightRangeAndIntensity()
    {
        if(lightExpanded == false)
        {
            Light2D light = this.GetComponent<Light2D>();
            light.pointLightOuterRadius += 1 * _speed * Time.deltaTime;
            light.intensity += 1 * _speed * Time.deltaTime;
        }
    }

    private void RetractLightRangeAndIntensity()
    {
        Light2D light = this.GetComponent<Light2D>();
        light.pointLightOuterRadius -= 1 * _speed * Time.deltaTime;
        light.intensity -= 1 * _speed * Time.deltaTime;
    }
}
