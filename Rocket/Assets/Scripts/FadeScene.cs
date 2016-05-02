using UnityEngine;
using System.Collections;

public class FadeScene : MonoBehaviour {

    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;

    private int drawDepth = -1000;
    private float alpha = 1f;
    private int fadeDirection = -1; //direccion para fade in = 1 y fade out -1




	void OnGUI()
    {
        //fade out/in the alpha value using  a direction, a speed and Time.deltatime will conver the operation to seconds
        alpha += fadeDirection * fadeSpeed * Time.deltaTime;

        alpha = Mathf.Clamp01(alpha);
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture ( new Rect(0, 0, Screen.width, Screen.height),fadeOutTexture);


    }

    public float BeginFade(int direction)
    {
        fadeDirection = direction;
        return fadeSpeed;
    }

    void OnLevelWasLoaded()
    {
        //alpha = 1;
        BeginFade(-1);

    }

}
