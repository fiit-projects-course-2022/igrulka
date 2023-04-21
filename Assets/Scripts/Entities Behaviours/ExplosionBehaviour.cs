using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ExplosionBehaviour : MonoBehaviour
{
    private Stopwatch timeAlive;

    private HUDController HUD;
    // Start is called before the first frame update
    void Start()
    {
        timeAlive = new Stopwatch();
        timeAlive.Start();
        HUD = GameObject.Find("HUD").GetComponent<HUDController>();
        HUD.IncreaseKillCount();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timeAlive.ElapsedMilliseconds > 500)
        {
            timeAlive.Stop();
            Destroy(gameObject);
        }
    }
}