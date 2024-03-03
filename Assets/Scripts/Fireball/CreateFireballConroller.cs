using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFireballConroller : MonoBehaviour
{
    public Fireball fireballPrefab;
    public Transform fireballSource;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, fireballSource.position, fireballSource.rotation);
        }
    }
}
