﻿using System.Collections.Generic;
using UnityEngine;

namespace RuntimeHelper.Visuals
{
    public class DrawObjectBounds : MonoBehaviour
    {        
        public TransformInfo transformBase;

        private List<GameObject> lineContainers = new List<GameObject>();

        private void Awake()
        {
            Transform parent = transform.parent;
            transformBase = new TransformInfo(parent.localPosition, parent.localRotation, parent.localScale);

            if (parent.GetType().Equals(typeof(RectTransform)))
            {
                gameObject.CreateLineContainers(ref lineContainers, ContainerType.Rectangle, 0.008f, Color.green, false);

                lineContainers.DrawRectangle((RectTransform)parent);
            }
            else
            {
                gameObject.CreateLineContainers(ref lineContainers, ContainerType.Box, 0.008f, Color.green, false);               

                lineContainers.DrawBox(Vector3.zero, Vector3.one);
            }

            gameObject.CreatePointerLine(PointerType.Object);

            Main.AllVisuals.Add(gameObject);
        }

        public void IsDraw(bool value)
        {
            gameObject.SetActive(value);
        }        
    }
}
