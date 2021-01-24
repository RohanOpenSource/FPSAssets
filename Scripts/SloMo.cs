using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
public class SloMo : MonoBehaviour
{
    public bool canSloMo=true;
    public Volume p;
    public WallRunTutorial player;

    void Update()
    {
        if (Input.GetKey("e") && canSloMo)
        {
            Time.timeScale = 0.2f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            player.sensitivity = 250;
            if (p.profile.TryGet<ChromaticAberration>(out var bloom))
            {
                bloom.intensity.overrideState = true;
                bloom.intensity.value = 1f;
            }
            if (p.profile.TryGet<Vignette>(out var v))
            {
                v.intensity.overrideState = true;
                v.intensity.value = 0.5f;
            }
        }
        if (Input.GetKeyDown("p"))
        {
            p.enabled = !p.enabled;
        }
        if (Input.GetKeyUp("e")){
            Time.timeScale = 1;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            player.sensitivity = 50;
            canSloMo = false;
            if (p.profile.TryGet<ChromaticAberration>(out var bloom))
            {
                bloom.intensity.overrideState = true;
                bloom.intensity.value = 0f;
            }
            if (p.profile.TryGet<Vignette>(out var v))
            {
                v.intensity.overrideState = true;
                v.intensity.value = 0.25f;
            }
            StartCoroutine(SloMoCooldown());
        }
    }
    private IEnumerator SloMoCooldown()
    {
        yield return new WaitForSeconds(10);
        canSloMo = true;
    }
}
