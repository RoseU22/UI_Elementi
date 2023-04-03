using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
    public GameObject Bean;
    public GameObject Teddy;
    public GameObject Grandma;
    public GameObject Car;
	public GameObject PaKreisi;
	public GameObject PaLabi;
	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;

    public void BeanAttels(bool vertiba)
    {
        Bean.SetActive(vertiba);
		PaKreisi.GetComponent<Toggle> ().interactable = vertiba;
		PaLabi.GetComponent<Toggle> ().interactable = vertiba;
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

	public void PaKreisiBean(){
		Bean.transform.localScale = new Vector2 (1, 1);
	}

	public void PaLabiBean(){
		Bean.transform.localScale = new Vector2 (-1, 1);
	}

	public void Izkritosais(int indekss){
		if (indekss == 0)
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [0];
		else if (indekss == 1)
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [1];
		else if (indekss == 2)
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [2];
	}
}
