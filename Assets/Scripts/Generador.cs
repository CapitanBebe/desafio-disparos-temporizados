using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    // Propiedades
    public float spawnrate = 1f;
    public GameObject Bala;
    public float whenToStart = 1f;
    public bool dispara = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dispara)
        {
            dispara = false;
            Generator();
            Invoke("canYouDoThis",spawnrate);
        }
    }
    void Generator()
    {
        Instantiate(Bala, transform.position, transform.localRotation);
    }
    void canYouDoThis()
    {
        dispara = true;
    }
}
