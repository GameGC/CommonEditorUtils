using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

[CustomPropertyDrawer(typeof(CoolToggle))]
public class CoolToggleDrawer : PropertyDrawer
{
    private new CoolToggle attribute => (CoolToggle)base.attribute;
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUIContent title = string.IsNullOrEmpty(attribute.Title)
            ? label
            : EditorGUIUtility.TrTextContent(property.displayName);
        position.x += 15 * EditorGUI.indentLevel;
        property.boolValue = ToggleDrawer.CustomToggle(position, property.boolValue, title);
    }

    public override bool CanCacheInspectorGUI(SerializedProperty property)
    {
        return false;
    }
}