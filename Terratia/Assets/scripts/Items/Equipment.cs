using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class Equipment : Items
{   
    [HideInInspector] public TypetypeOf—lothing TypeOfClothing;
    [HideInInspector] public int AddArmor;
    [HideInInspector] public int —apacity;
    public TypeEquipment TypeEquipments;
    public enum TypetypeOf—lothing
    {
        headdress,
        outerwear,
        underwear,
        boots
    }
    public enum TypeEquipment
    {
        clothes,
        armor,
        backpack
    }

}
[CustomEditor(typeof(Equipment)), CanEditMultipleObjects]
public class PropertyEquipmentEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Equipment equipment = (Equipment)target;
        switch (equipment.TypeEquipments)
        {
            case Equipment.TypeEquipment.clothes:
                equipment.TypeOfClothing = (Equipment.TypetypeOf—lothing)EditorGUILayout.EnumPopup(equipment.TypeOfClothing);
                break;
            case Equipment.TypeEquipment.armor:
                equipment.AddArmor = EditorGUILayout.IntField("armore", equipment.AddArmor);
                equipment.TypeOfClothing = (Equipment.TypetypeOf—lothing)EditorGUILayout.EnumPopup(equipment.TypeOfClothing);
                break;
            case Equipment.TypeEquipment.backpack:
                equipment.—apacity = EditorGUILayout.IntField("capacity",equipment.—apacity);
                break;
            default:
                Debug.LogError("Error don`t typeEquipments");
                break;
        }

    }

}
     