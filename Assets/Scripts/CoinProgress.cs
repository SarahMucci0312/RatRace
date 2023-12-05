using UnityEngine;

public class CoinProgress : MonoBehaviour
{
    //Progress Bar Variables
    public float progress, maxProgress;
    [SerializeField] private PermaUpgradesBar progressBar;

    //Set max possible progress on progress bar
    void Start()
    {
        progressBar.SetMaxProgress(maxProgress);
    }

    //Update progress bar as player collects coins
    public void SetNewProgress(float changePro)
    {
        progress += changePro;
        progress = Mathf.Clamp(progress, 0, maxProgress);

        progressBar.setProgress(progress);
    }

    private void OnCollisionEnter(Collision other)
    {
        //Check value of coin on collision
        if (other.gameObject.CompareTag("Coin"))
        {
            if(SetParams.isDouble == true)
            {
                SetNewProgress(2f);
            }
            else
            {
                SetNewProgress(1f);
            }
        }
    }

}
