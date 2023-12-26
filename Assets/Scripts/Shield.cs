using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    
    public float Speed { get; set; }

    private void FixedUpdate()
    {
        this.transform.Translate(Speed * Time.fixedDeltaTime, 0, 0);
    }
}
