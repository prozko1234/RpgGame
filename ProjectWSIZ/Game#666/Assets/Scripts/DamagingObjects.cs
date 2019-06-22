﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingObjects : MonoBehaviour {

    public float damage = 1;

    private void OnCollisionStay2D(Collision2D collision)
    {
        collision.gameObject.SendMessage("Damage", damage);
    }

}
