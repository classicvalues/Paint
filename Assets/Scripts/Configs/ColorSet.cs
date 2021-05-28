using System.Collections.Generic;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "ColorSet", menuName = "ColorSet", order = 0)]
    public class ColorSet : ScriptableObject
    {
        public List<Color> Colors = new List<Color>
        {
            new Color32(0x00, 0x00, 0x00, 0xFF),
            new Color32(0x22, 0x20, 0x34, 0xFF),
            new Color32(0x45, 0x28, 0x3c, 0xFF),
            new Color32(0x66, 0x39, 0x31, 0xFF),
            new Color32(0x8f, 0x56, 0x3b, 0xFF),
            new Color32(0xdf, 0x71, 0x26, 0xFF),
            new Color32(0xd9, 0xa0, 0x66, 0xFF),
            new Color32(0xee, 0xc3, 0x9a, 0xFF),
            new Color32(0xfb, 0xf2, 0x36, 0xFF),
            new Color32(0x99, 0xe5, 0x50, 0xFF),
            new Color32(0x6a, 0xbe, 0x30, 0xFF),
            new Color32(0x37, 0x94, 0x6e, 0xFF),
            new Color32(0x4b, 0x69, 0x2f, 0xFF),
            new Color32(0x52, 0x4b, 0x24, 0xFF),
            new Color32(0x32, 0x3c, 0x39, 0xFF),
            new Color32(0x3f, 0x3f, 0x74, 0xFF),
            new Color32(0x30, 0x60, 0x82, 0xFF),
            new Color32(0x5b, 0x6e, 0xe1, 0xFF),
            new Color32(0x63, 0x9b, 0xff, 0xFF),
            new Color32(0x5f, 0xcd, 0xe4, 0xFF),
            new Color32(0xcb, 0xdb, 0xfc, 0xFF),
            new Color32(0xff, 0xff, 0xff, 0xFF),
            new Color32(0x9b, 0xad, 0xb7, 0xFF),
            new Color32(0x84, 0x7e, 0x87, 0xFF),
            new Color32(0x69, 0x6a, 0x6a, 0xFF),
            new Color32(0x59, 0x56, 0x52, 0xFF),
            new Color32(0x76, 0x42, 0x8a, 0xFF),
            new Color32(0xac, 0x32, 0x32, 0xFF),
            new Color32(0xd9, 0x57, 0x63, 0xFF),
            new Color32(0xd7, 0x7b, 0xba, 0xFF),
            new Color32(0x8f, 0x97, 0x4a, 0xFF),
            new Color32(0x8a, 0x6f, 0x30, 0xFF)
        };
    }
}