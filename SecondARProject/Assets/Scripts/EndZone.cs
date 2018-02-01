using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndZone : MonoBehaviour {

    public Text WinLabel;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sphere")
            WinLabel.text = "YAY!";
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "sphere")
            WinLabel.text = "";
    }
}
