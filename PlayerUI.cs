using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider hpSlider;
    // Update is called once per frame
    void Update()
    {
        hpSlider.maxValue = player.maxHP;
        hpSlider.value = player.HP;
        coinsCounterText.text = player.coins.ToString();
    }
}
