using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Rotating());
    }

    IEnumerator Rotating()
    {
        while (true)
        {
            transform.Rotate(Vector3.up, speed);
            yield return null;
        }
    }
}
