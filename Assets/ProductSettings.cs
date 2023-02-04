using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Granaja
{
    public class ProductSettings : ScriptableObject
    {
        [Header("Caracteristics")]
        [Space]
        [SerializeField] FruitType fruit;
        [SerializeField] int[] spaces;
        public int currentLevel = 0;
        [Space(10)]
        [Header("Sells")]
        [Space]
        [SerializeField] int maxProduction;
        [SerializeField] int[] upgredeCost;
        [SerializeField] float[] costBuy;
        [SerializeField] float[] costSell;

        public FruitType Fruit { get => fruit; }
        public int[] Spaces { get => spaces; }
        public int MaxProduction { get => maxProduction; }
        public int[] UpgredeCost { get => upgredeCost; }
        public float CostBuy { get => costBuy[currentLevel]; }
        public float CostSell { get => costSell[currentLevel]; }

        public virtual Producto Get_Product()
        {
            return new Producto(AnimalType.None, fruit);
        }
    }
}
