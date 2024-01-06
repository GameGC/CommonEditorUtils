using UnityEngine;

public class CoolToggle : PropertyAttribute
{
    public readonly string Title;

    public CoolToggle(string toggleTitle)
    {
        Title = toggleTitle;
    }
}