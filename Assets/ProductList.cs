using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace Granaja
{
    [CreateAssetMenu(fileName = "Producto", menuName = "Granja/Lista de productos", order = 3)]
    public class ProductList : ScriptableObject
    {
        [SerializeField] bool shouldStart = true;
        [Space(20)]
        [SerializeField] ProductSettings[] products;

        Dictionary<(AnimalType, FruitType), ProductSettings> productList = null;

        public ProductSettings[] Products { get => products; }

        #region public methods
        public ProductSettings Get_Product(AnimalType animal, FruitType fruit = FruitType.None)
        {
            if (shouldStart) Initilice();

            return productList[(animal, fruit)];
        }

        public ProductSettings Get_Product(FruitType fruit)
        {
            if (shouldStart) Initilice();

            return productList[(AnimalType.None, fruit)];
        }

        public ProductSettings Get_Product(Producto product)
        {
            if (shouldStart) Initilice();

            return productList[(product.animal, product.fruit)];
        }

        public List<ProductSettings> Get_Animals()
        {
            if (shouldStart) Initilice();

            var result = new List<ProductSettings>();

            foreach (var item in productList)
            {
                if (item.Key.Item1 != AnimalType.None)
                    result.Add(item.Value);
            }

            return result.Count > 0 ? result : null;
        }

        public List<ProductSettings> Get_Fruits()
        {
            if (shouldStart) Initilice();

            var result = new List<ProductSettings>();

            foreach (var item in productList)
            {
                if (item.Key.Item1 == AnimalType.None && item.Key.Item2 != FruitType.None)
                    result.Add(item.Value);
            }

            return result.Count > 0 ? result : null;
        }

        public List<ProductSettings> Get_Mutated()
        {
            if (shouldStart) Initilice();

            var result = new List<ProductSettings>();

            foreach (var item in productList)
            {
                if (item.Key.Item1 != AnimalType.None && item.Key.Item2 != FruitType.None)
                    result.Add(item.Value);
            }

            return result.Count > 0 ? result : null;
        }

        public bool Contains(AnimalType animal, FruitType fruit)
        {
            if (shouldStart) Initilice();

            return productList.ContainsKey((animal, fruit));
        } 
        #endregion

        private void Initilice()
        {
            if (!shouldStart) return;

            productList = new Dictionary<(AnimalType, FruitType), ProductSettings>();

            foreach (var product in products)
            {
                (AnimalType, FruitType) keys = product switch {
                    Animal a => (a.Animaltype, a.Fruit),
                    Fruit c => (AnimalType.None, c.Fruit),
                    _ => default
                };

                productList.Add(keys, product);
            }

            shouldStart = false;
        }
    }
}
