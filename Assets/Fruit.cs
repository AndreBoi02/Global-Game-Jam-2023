using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Granaja
{
    [CreateAssetMenu(fileName = "Producto", menuName = "Granja/Fruta", order = 1)]
    public class Fruit : ProductSettings
    {
        [SerializeField] GrowingRate[] growingRate;

        public GrowingRate[] State { get => growingRate; }
    }

    public enum CropState
    {
        None,
        Retonio,
        Media,
        Cosecha
    }

    [Serializable]
    public struct GrowingRate
    {
        public CropState state;
        public float time;
    }
}
