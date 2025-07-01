using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBalls : MonoBehaviour
{
    public GameObject ballPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomPos = new Vector3(Random.Range(-400, 400), Random.Range(600, 1001), Random.Range(-400, 400));
            //Vector3 randomPos = new Vector3(0, 600, 0);
            
            Instantiate(ballPrefab, randomPos, Quaternion.identity);
        }
    }
}
