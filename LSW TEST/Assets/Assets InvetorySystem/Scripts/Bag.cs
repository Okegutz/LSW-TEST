using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bag : MonoBehaviour
{
    [SerializeField] private int totalGold;
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] GameObject objectEquipment;

    private int bagSize;
    private int bagElements;

    private void Start()
    {
        totalGold = 50;
        bagSize = 1;
        bagElements = 0;
        goldText.text = totalGold.ToString();
    }
    public void AddEquipment(int gold, Image equipmentImage)
    {
        if (gold <= totalGold && bagSize <= 1)
        {
            totalGold -= gold;
            bagElements++;
            GameObject equipment = GameObject.Instantiate(objectEquipment, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Equipment").transform);
            Image image = equipment.GetComponent<Image>();
            image.sprite = equipmentImage.sprite;
            goldText.text = totalGold.ToString();
        }
    }
}
