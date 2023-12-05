using UnityEngine;

public class Coin : MonoBehaviour
{
    //Coin variables
    public AudioSource collectSound; //Sound variable
    public Material material1; //Gold coin
    public Material material2; //Teal coin
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        //Change coin color if power-up is activated
        if(SetParams.isDouble == true)
        {
            meshRenderer.material = material2;
        }
        else
        {
            meshRenderer.material = material1;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        //Update point value on collision with coins
        if (other.gameObject.CompareTag("Player"))
        {
            collectSound.Play();
            if (SetParams.isDouble == true)
            {
                SetParams.DoublePoints();
            }
            else
            {
                SetParams.IncreasePoints();
            }
            gameObject.SetActive(false);
        } 
    }

}
