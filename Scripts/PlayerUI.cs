using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text health;
    public Text ammo;
    public Gun current;
    public Text SloMo;
    public SloMo manager;
    // Update is called once per frame
    void Update()
    {
        health.text = ("Health: " + GetComponent<life>().health);
        ammo.text = "Ammo: "+(current.shotsBeforeReload-current.shots);
        if (manager.canSloMo)
        {
            SloMo.text = "Slow Motion Is Ready";
        }
        else if (!manager.canSloMo)
        {
            SloMo.text = "";
        }
    }
}
