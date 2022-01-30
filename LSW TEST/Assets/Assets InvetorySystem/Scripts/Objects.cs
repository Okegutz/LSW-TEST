using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Objects : MonoBehaviour
{
    [SerializeField] Image objectImage;
    [SerializeField] TextMeshProUGUI objectText;
    [SerializeField] TextMeshProUGUI objectPrice;

    private int price;
    private Bag bag;

    private void Awake()
    {
        bag = FindObjectOfType<Bag>();

    }

    public void CreateObject(ObjectTemplate objectData)
    {
        price = objectData.objectPrice;
        objectImage.sprite = objectData.objectImage;
        objectText.text = objectData.objectName;
        objectPrice.text = objectData.objectPrice.ToString();
    }
    public void buyObject()
    {
        bag.AddEquipment(price, objectImage);
        Debug.Log("Comprando!");
    }
}
