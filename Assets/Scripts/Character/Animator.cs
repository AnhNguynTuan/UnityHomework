using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator : MonoBehaviour
{
    public CharController charController;
    private void Awake()
    {
        charController = GetComponent<CharController>();
    }
}
