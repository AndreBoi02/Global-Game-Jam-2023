using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResGen : MonoBehaviour
{
    private int baseLvl1 = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name.Contains("Blue"))
            StartCoroutine(Blueberry());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (gameObject.name.Contains("Blue"))
            StopCoroutine(Blueberry());
            Statcon.gainedBlue += Statcon.blueberry;
            Statcon.blueberry = 0;
            Debug.Log(Statcon.gainedBlue);
            StartCoroutine(Blueberry());
    }

    IEnumerator Blueberry()
    {
        yield return new WaitForSeconds(5);
        Statcon.blueberry += 1 * baseLvl1;
        if(Statcon.blueberry < 5)
            StartCoroutine(Blueberry());
    }
}
