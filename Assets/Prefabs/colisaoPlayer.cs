﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisaoPlayer : MonoBehaviour {

    [SerializeField]
    Collider2D outro;
    private void Awake()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), outro, true);
    }
}
