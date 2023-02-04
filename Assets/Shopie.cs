using System;
using System.Collections.Generic;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

namespace Granaja
{
    public class Shopie : MonoBehaviour
    {
        [SerializeField] ProductList products;
        private Inventarie inventarie;
        public GameObject productUI;
        public GameObject parent;

        public ProductList Products { get => products; }
        private List<GameObject> uiProducts;

        private void Awake()
        {
            FindObjectOfType<Inventarie>();
        }

        private void OnEnable()
        {
            uiProducts = new List<GameObject>();

            int i = 0;
            foreach (var product in Products.Products)
            {
                var hi = Instantiate(productUI, parent.transform);
                hi.transform.position += Vector3.right * i * 150;

                var pro = hi.GetComponent<UIProduct>();

                pro.txtName.text = product.name;
                pro.txtCost.text = product.CostBuy.ToString();
                uiProducts.Add(hi);
                i++;
            }
        }

        private void OnDisable()
        {
            foreach (var item in uiProducts)
            {
                Destroy(item);
            }
        }

        public bool Buy(Producto product)
        {
            return inventarie.Purchase(product);
        }

        public bool Sell(Producto product)
        {
            return false;
        }
    }
}
