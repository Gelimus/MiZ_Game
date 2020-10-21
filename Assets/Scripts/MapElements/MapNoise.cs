using UnityEngine;
using System.Collections;

// Create a texture and fill it with Perlin noise.
// Try varying the xOrg, yOrg and scale values in the inspector
// while in Play mode to see the effect they have on the noise.

public class MapNoise : MonoBehaviour
{

    // The number of cycles of the basic noise pattern that are repeated
    // over the width and height of the texture.
    private float resolution = 0.3f;

    private float transparency =0.3f;

    private float colorVariance = 0.4f;

    //KONIEC POKRĘTEŁ

    private Texture2D noiseTex;
    private Color[] pix;
    private Renderer rend;

    public void LetThereBeNoise(int pixWidth, int pixHeight, float tileScale)
    {
        rend = GetComponent<Renderer>();


        // Set up the texture and a Color array to hold pixels during processing.
        noiseTex = new Texture2D(pixWidth, pixHeight);
        pix = new Color[noiseTex.width * noiseTex.height];
        rend.sortingLayerName = "Noise";

        Vector2 noiseTexPivot = new Vector2(tileScale/(2 * pixWidth), 1-(tileScale/(2 * pixHeight)));

        ((SpriteRenderer)rend).sprite = Sprite.Create(noiseTex, new Rect(0f, 0f, noiseTex.width, noiseTex.height),noiseTexPivot, 64f);
        CalcNoise();
        //new Vector2(-tileScale/2, pixHeight-tileScale/2)
    }

    void CalcNoise()
    {
        float redOffset = Random.Range(0f, colorVariance);
        float greenOffset = Random.Range(0f, colorVariance);
        float blueOffset = Random.Range(0f, colorVariance);

        Debug.Log("Making Noise! ("+ noiseTex.height + " x "+ noiseTex.width + ")");

        for (int y=0; y < noiseTex.height; y++)
        {
            for (int x =0; x < noiseTex.width; x++)
            {
                float xCoord =  x / (noiseTex.width * resolution);
                float yCoord =  y / (noiseTex.height * resolution);
                float sample = Mathf.PerlinNoise(xCoord, yCoord);
                float redNoise = Mathf.PerlinNoise(xCoord * redOffset, yCoord * redOffset);
                float greenNoise = Mathf.PerlinNoise(xCoord * greenOffset, yCoord * greenOffset);
                float blueNoise = Mathf.PerlinNoise(xCoord * blueOffset, yCoord * blueOffset);

                pix[y * noiseTex.width + (int)x] = new Color(redNoise, greenNoise, blueNoise, sample*transparency);
            }
        }

        // Copy the pixel data to the texture and load it into the GPU.
        noiseTex.SetPixels(pix);
        noiseTex.Apply();
    }
}