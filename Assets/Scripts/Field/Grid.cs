using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    private Node[,] m_Nodes;
    private int m_Width;
    private int m_Height;

    public Grid(int width, int height)
    {
        m_Width = width;
        m_Height = height;

        m_Nodes = new Node[width, height];

        for (int i = 0; i < m_Nodes.GetLength(dimension: 0); i++)
        {
            for (int j = 0; j < m_Nodes.GetLength(dimension: 1); j++)
            {
                m_Nodes[i, j] = new Node();
            }
        }
    }

    public Node GetNode(Vector2Int coordinate)
    {
        return GetNode(i: coordinate.x, j: coordinate.y);
    }

    public Node GetNode(int i, int j)
    {
        if (i < 0 || i >= m_Width)
        {   
            return null;
        }

        if(j < 0 || j >= m_Height) { return null; }

        return m_Nodes[i, j];
    }
}
