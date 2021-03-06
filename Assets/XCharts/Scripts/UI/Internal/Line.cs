﻿using UnityEngine;

namespace XCharts
{
    [System.Serializable]
    public class Line
    {
        [SerializeField] private float m_Tickness;
        [SerializeField] private bool m_Point;
        [SerializeField] private float m_PointWidth;
        [SerializeField] private bool m_Smooth;
        [SerializeField] [Range(1f, 10f)] private float m_SmoothStyle;
        [SerializeField] private bool m_Area;
        [SerializeField] private Color m_AreaColor;

        public float tickness { get { return m_Tickness; } set { m_Tickness = value; } }
        public bool point { get { return m_Point; } set { m_Point = value; } }
        public float pointWidth { get { return m_PointWidth; } set { m_PointWidth = value; } }
        public bool smooth { get { return m_Smooth; } set { m_Smooth = value; } }
        public float smoothStyle { get { return m_SmoothStyle; } set { m_SmoothStyle = value; } }
        public bool area { get { return m_Area; } set { m_Area = value; } }
        public Color areaColor { get { return m_AreaColor; } set { m_AreaColor = value; } }

        public static Line defaultLine
        {
            get
            {
                var line = new Line
                {
                    m_Tickness = 0.8f,
                    m_Point = true,
                    m_PointWidth = 2.5f,
                    m_Smooth = false,
                    m_SmoothStyle = 2f,
                    m_Area = false
                };
                return line;
            }
        }
    }
}