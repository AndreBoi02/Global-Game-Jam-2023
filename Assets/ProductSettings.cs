using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace Granaja
{
    public class ProductSettings : ScriptableObject
    {
        [Header("Caracteristics")]
        [Space]
        [SerializeField] FruitType fruit;
        [SerializeField] int spaces;
        [Space(10)]
        [Header("Sells")]
        [Space]
        [SerializeField] int maxProduction;
        [SerializeField] float costBuy;
        [SerializeField] float costSell;
        [SerializeField] Sprite image;

        public FruitType Fruit { get => fruit; }
        public int Spaces { get => spaces; }
        public int MaxProduction { get => maxProduction; }
        public float CostBuy { get => costBuy; }
        public float CostSell { get => costSell; }
        public Sprite Image { get => image; }

        public virtual Producto Get_Product()
        {
            return new Producto(AnimalType.None, fruit);
        }
    }
}
