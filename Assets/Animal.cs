using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Granaja
{
    [CreateAssetMenu(fileName = "Producto", menuName = "Granja/Animal", order = 0)]
    public class Animal : ProductSettings
    {
        [Space(10)]
        [Header("Product")]
        [Space]
        [SerializeField] ProductType productType;
        [SerializeField] float normalCost;
        [SerializeField] float productionTime;
        [SerializeField] float mutatedCost;
        [SerializeField] float mutatedProductionTime;
        [Space(30)]
        [SerializeField] AnimalType animal;

        public ProductType ProductType { get { return productType; } }
        public float NormalCost { get => normalCost; }
        public float ProductionTime { get => productionTime; }
        public float MutatedCost { get => mutatedCost; }
        public float MutatedProductionTime { get => mutatedProductionTime; }
        public AnimalType Animaltype { get => animal; }

        public override Producto Get_Product()
        {
            return new Producto(animal, Fruit);
        }
    }
}
