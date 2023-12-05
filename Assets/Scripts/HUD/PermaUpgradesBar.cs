using UnityEngine;

public class PermaUpgradesBar : MonoBehaviour
{
    [SerializeField] private RectTransform progressBar;

    public float progress, maxProgress, width, height;
    
    //Sets maximum value for upgrades progress bar
    public void SetMaxProgress(float maxPro)
    {
        maxProgress = maxPro;
    }

    //Sets progress in progress bar
    public void setProgress(float pro)
    {
        progress = pro;
        float newWidth = (progress / maxProgress) * width;
        progressBar.sizeDelta = new Vector2(newWidth, height);
    }
}
