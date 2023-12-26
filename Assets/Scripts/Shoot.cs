using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    Camera camera;
    [SerializeField]
    TextMeshProUGUI score;
    [SerializeField]
    AudioSource plateBreak;

    readonly string SCORETEXT = "Score: ";
    int counter = 0;

    private void Awake()
    {
        score.text = SCORETEXT + counter;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.GetComponent<Shield>() != null)
                {
                    Destroy(hit.transform.gameObject);
                    counter++;
                    score.text = SCORETEXT + counter;
                    plateBreak.Play();
                }
            }
        }


    }
}
