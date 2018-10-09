using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrbit : MonoBehaviour {

    public Orbit orbitPath;
    public Transform orbitingplayer;

    [Range(0f, 1f)]
    public float progress = 0f;
    public float orbitperiod = 3f;
    public bool orbitActive = true;

    void Start()
    {
        if (orbitPath == null)
        {
            orbitActive = false;
            return;
        }
        //set player
        setPlayerpos();
        // start orbit animation
        StartCoroutine( AnimateOrbit() );
    }
    void setPlayerpos()
    {
        Vector2 orbitpos = orbitPath.Evaluate(progress);
        orbitingplayer.localPosition = new Vector2(orbitpos.x, orbitpos.y);
        
    }

    IEnumerator AnimateOrbit()
    {
        if (orbitperiod < 0.1f)
        {
            orbitperiod = 0.1f;
        }
        float orbitSpeed = 1f / orbitperiod;

        while (orbitActive)
        {
            progress += Time.deltaTime * orbitSpeed;
            progress %= 1f;
            setPlayerpos();
            yield return null;
        }

    }
}
