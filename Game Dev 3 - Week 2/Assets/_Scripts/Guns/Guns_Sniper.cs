using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Guns
{
    public class Guns_Sniper : Guns_Parent
    {
        // Start is called before the first frame update
        public override void GunSound()
        {
            gunAudioSource.pitch = Random.Range(0.6f, 1.4f);
            gunAudioSource.PlayOneShot(gunSound);
        }
    }
}
