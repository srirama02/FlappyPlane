using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CountdownText : MonoBehaviour {

    public delegate void CountdownFinished();
    public static event CountdownFinished OnCountdownFinished;

    Text countdown;

    void OnEnable() {
        countdown = GetComponent<Text>();
        countdown.text = 3.ToString();
        StartCoroutine("Countdown");
    }

    IEnumerator Countdown() {
        yield return new WaitForSeconds(1);
        countdown.text = 2.ToString();
        yield return new WaitForSeconds(1);
        countdown.text = 1.ToString();
        yield return new WaitForSeconds(1);
        /*
        int count = 3;

        for (int i = 0; i < count; i++) {
            countdown.text = (count - 1).ToString();
            //yield return new WaitForSeconds(1);
        }
        */
        OnCountdownFinished();

    }

}
