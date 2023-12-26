using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabShield;
    [SerializeField]
    float speed;
    [SerializeField]
    float spawnSpeed;

    private void Start()
    {
        InvokeRepeating("spawnShield", 0f, spawnSpeed);
    }

    void spawnShield()
    {
        GameObject shield = Instantiate(prefabShield, this.transform);
        shield.GetComponent<Shield>().Speed = speed;
    }
}
