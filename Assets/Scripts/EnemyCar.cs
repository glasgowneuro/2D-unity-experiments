﻿using UnityEngine;
using System.Collections;

public class EnemyCar : MonoBehaviour {
    public SpriteRenderer spriteRenderer;

    private Vector3 position;
    private readonly float carSpeed = -3;
    private readonly float speed = 1f;

    private SpriteRenderer sr;

    // Use this for initialization
    void Start () {
        sr = GameObject.Find("CameraScreen").GetComponent<SpriteRenderer>();
        if (sr == null) {
            Debug.LogError("CameraScreen cannot be found");
        }
    }

    // Update is called once per frame
    void Update () {
        Camera cam = gameObject.GetComponent<Camera>();
        cam.Render();
        Texture2D newTex = ToTexture2D(cam.activeTexture);
        Color[] pixels = newTex.GetPixels(0, 0, newTex.width, newTex.height);
        float avg = 0.0F;
        for (int i=0; i<newTex.width; i++)
        {
            for (int j=0; j<newTex.height; j++)
            {
                avg += pixels[i + newTex.width * j].grayscale / (float)pixels.GetLength(0);
            }
        }
        // Debug.LogError("Avg: " + avg);

        Rect r = new Rect(0,0, newTex.width / 3, newTex.height / 3);
        sr.sprite = Sprite.Create(newTex, r, new Vector2(0.5f, 0.5f));
        float x = Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * carSpeed;
        transform.Translate (new Vector2 (x, (speed+y) * Time.deltaTime));
	}

    Texture2D ToTexture2D(RenderTexture rTex)
    {
        Texture2D tex = new Texture2D(512, 512, TextureFormat.RGB24, false);
        RenderTexture.active = rTex;
        tex.ReadPixels(new Rect(0, 0, rTex.width, rTex.height), 0, 0);
        tex.Apply();
        return tex;
    }


    Sprite Texture2DToSprite(Texture2D text2D)
    {
        Sprite sprite = Sprite.Create(text2D, new Rect(0, 0, text2D.width, text2D.height), Vector2.zero);
        return sprite;
    }
}
