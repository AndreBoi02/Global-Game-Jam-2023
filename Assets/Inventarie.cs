using System.Collections.Generic;
using System;
using UnityEngine;
using Unity.VisualScripting;

namespace Granaja
{
    public class Inventarie : MonoBehaviour
    {
        [SerializeField] float money = 0;
        [SerializeField] List<(Producto product, int amount)> products = new List<(Producto, int)> ();
        [SerializeField] ProductList productList;

        public event Action OnMoneyChange = delegate { };

        public float Money { get { return money; } }

        public bool Add(in Producto product)
        {
            if (productList.Contains(product.animal, product.fruit))
            {
                products.Add((product, 1));
                return true;
            }

            return false;
        }

        public bool Remove(in Producto product)
        {
            if (productList.Contains(product.animal, product.fruit))
            {
                int idx;
                if (Contains(product, out idx))
                {
                    products.RemoveAt(idx);
                    return true;
                }
            }

            return false;
        }

        public bool Purchase(Producto product)
        {
            var prod = productList.Get_Product(product);

            if (money - prod.CostBuy >= 0) return false;

            int idx = 0;
            if (!Contains(product, out idx))
                Add(product);

            if (products[idx].amount > 0)
            {
                int res = products[idx].amount - 1;
                products[idx] = (product, res);
            }
            else
                products.RemoveAt(idx);

            money -= prod.CostBuy;
            OnMoneyChange.Invoke();

            return true;
        }

        public bool Contains(Producto product, out int idx)
        {
            idx = 0;

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].product == product)
                {
                    idx = i;
                    return true;
                }
            }

            return false;
        }
    }

    public enum AnimalType
    {
        None,
        Cerdo,
        Oveja,
        Cabra,
        Vaca,
        Pollo
    }

    public enum FruitType
    {
        None,
        Blueberry,
        Fresa,
        Uva,
        Sandia,
        Platano
    }

    public enum ProductType
    {
        None,
        Tocino,
        Lana,
        Queso,
        Leche,
        Huevos
    } 
}
