using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using VVVV.PluginInterfaces.V1;
using VVVV.Utils.VMath;
using VVVV.Utils.VColor;

namespace DrawSmoother
{
    /// <summary>
    /// One particle
    /// </summary>
    public class Particle
    {
        /// <summary>
        /// ���������� ���������� �����
        /// </summary>
        public float x, y;
        /// <summary>
        /// ���������� ������������
        /// </summary>
        public float x1, y1, x2, y2;
        /// <summary>
        /// �����������
        /// </summary>
        public Particle() { }

        /// <summary>
        /// �������������
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        public Particle(float _x, float _y)
        {
            x = _x;
            y = _y;
            x1 = y1 = x2 = y2 = -1f;
        }
    }

}
