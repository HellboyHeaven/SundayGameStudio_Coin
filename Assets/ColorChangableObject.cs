using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangableObject : MonoBehaviour
{
   [SerializeField] private List<Color> colors;
   [SerializeField] private Renderer renderer;
   
   private int _currentColorIndex;
   
   private void OnMouseDown()
   {
      if (!renderer || colors.Count == 0) return;
      renderer.material.color = colors[_currentColorIndex];
      _currentColorIndex = (_currentColorIndex+1) % colors.Count;
   }
   
}
