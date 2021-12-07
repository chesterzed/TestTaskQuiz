using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellsSpawner : MonoBehaviour
{
    [SerializeField] private Vector2[] _levels;
    [SerializeField] private Cell _cell;

    private void Awake()
    {
        
    }

    private void GenerateGrid()
    {

    }

    private Color32 AverageColor(Texture2D img, int step)
    {
        Color32[] imgColors = img.GetPixels32();

        int total = imgColors.Length;

        float r = 0;
        float g = 0;
        float b = 0;

        for(int i = 0; i < total;  i += step)
        {
            r += imgColors[i].r;
            g += imgColors[i].g;
            b += imgColors[i].b;
        }

        return new Color32((byte)(r / total), (byte)(g / total), (byte)(b / total), 0);
    }
    
}
