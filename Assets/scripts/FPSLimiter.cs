using UnityEngine;

public class FramerateLimiter : MonoBehaviour
{
    public int targetFps = 60;

    void Awake()
    {
        // Set the target frame rate
        Application.targetFrameRate = targetFps;
    }
}
