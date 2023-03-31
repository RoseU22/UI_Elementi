using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour {
    public GameObject Bean;
    public GameObject Teddy;
    public GameObject Grandma;
    public GameObject Car;

    public void BeanAttels(bool vertiba)
    {
        Bean.SetActive(vertiba);
    }

    public void TeddyAttels(bool vertiba)
    {
        Teddy.SetActive(vertiba);
    }

    public void GrandmaAttels(bool vertiba)
    {
        Grandma.SetActive(vertiba);
    }

    public void CarAttels(bool vertiba)
    {
        Car.SetActive(vertiba);
    }
}
