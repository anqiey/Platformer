using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{

    private TextMeshProUGUI coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDiamond(PlayerInventory playerInventory)
    {
        coinText.text = playerInventory.NumberOfCoins.ToString();

    }

}