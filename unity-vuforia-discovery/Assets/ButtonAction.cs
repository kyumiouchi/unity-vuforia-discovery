using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour {


    public Button attackButton;
    public GameObject hose;
	// Use this for initialization
	void Start () {
        attackButton.onClick.AddListener(attackButtonDown);
	}

    private void attackButtonDown()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        hose.transform.Find("WaterShower").gameObject.SetActive(true);
        yield return new WaitForSeconds(2);

        hose.transform.Find("WaterShower").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
