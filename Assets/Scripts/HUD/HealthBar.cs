using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private RectTransform healthBar;

    public float maxHealth, width, height;

    //Sets maximum health
    public void SetMaxHealth(float maxHP)
    {
        SetParams.maxHealth = maxHP;
    }

    //Sets health
    public void setHealth(float hp)
    {
        SetParams.health = hp;
        float newWidth = (SetParams.health / SetParams.maxHealth) * width;
        healthBar.sizeDelta = new Vector2(newWidth, height);
    }
}
