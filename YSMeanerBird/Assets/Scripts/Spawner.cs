using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spikes Object for controling the game")]
    public GameObject spikes;
    [Header("Default Height")]
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantianteObjects",1f,4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5, Random.Range(-height, height),0);
    }

    void InstantianteObjects()
    {
        Instantiate(spikes, transform.position, transform.rotation);
    }
}
