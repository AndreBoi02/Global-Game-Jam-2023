using Granaja;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIProduct : MonoBehaviour
{
    Shopie shopie;
    public Image image;
    public Text txtName;
    public Text txtCost;
    public Producto producto;

    private void Awake()
    {
        shopie = FindObjectOfType<Shopie>();
    }

    
    public void Buy()
    {
        shopie.Buy(producto);
    }

    public void Sell()
    {

    }
}
