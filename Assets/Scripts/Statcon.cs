using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statcon : MonoBehaviour
{
    public static int blueberry = 0;
    public static int gainedBlue = 0;
    public static int strawberry = 0;
    public static int gainedStraw = 0;
    public static int grape = 0;
    public static int gainedGrape = 0;
    public static int watermelon = 0;
    public static int gainedWatermelon = 0;
    public static int banana = 0;
    public static int gainedBanana = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(blueberry + " " + strawberry + " " + grape + " " + watermelon + " " + banana);
    }
}
