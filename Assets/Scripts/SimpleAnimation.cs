using UnityEngine;

public struct SimpleAnimation
{
    private bool isEnabled;
    private float[] interval;
    public SpriteRenderer spriteRenderer;
    private Sprite[] frames;
    private int frameIndex;
    private float frameTime;

    public void Enable(string name, float[] interval)
    {
        isEnabled = true;
        this.interval = interval;

        // Hardcoded as 2 frames
        frames = new Sprite[2]
        {
            Resources.Load<Sprite>("Images/" + name + "_0"),
            Resources.Load<Sprite>("Images/" + name + "_1")
        };
        frameIndex = 0;
        frameTime = 0.0F;

        // Set first frame
        spriteRenderer.sprite = frames[0];
    }

    public void Disable()
    {
        isEnabled = false;
        interval = null;
        frames = null;
        frameIndex = 0;
        frameTime = 0.0F;
    }

    public void Update()
    {
        if (isEnabled)
        {
            frameTime += Time.deltaTime;
            if (frameTime >= interval[frameIndex])
            {
                do
                {
                    frameTime -= interval[frameIndex];
                } while (frameTime >= interval[frameIndex]);

                // Hardcoded as 2 frames
                frameIndex = frameIndex == 0 ? 1 : 0;
            }
            if (spriteRenderer.sprite != frames[frameIndex])
            {
                spriteRenderer.sprite = frames[frameIndex];
            }
        }
    }
}
