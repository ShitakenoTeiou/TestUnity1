using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Intojson
{
    [System.Serializable]
    public class aaa
    {
        public int a = 1;
        public int b = 150;
        public bbb bclass = new bbb();
        public int[] intArr = new int[5] { 1, 2, 3, 4, 5 };
        public bbb[] bArr = new bbb[3];
        public List<ddd> dlist = new List<ddd>();
        ddd[] dArr = new ddd[3];

        public void ValueIntoArr()
        {
            for (int i = 0; i<3; i++)
            {
                bArr[i] = new bbb();
                dArr[i] = new ddd();
            }

            for (int i = 0; i < 3; i++)
            {
                dlist.Add(dArr[i]);
            }
        }
    }

    [System.Serializable]
    public class bbb
    {
        public int c = 30;
    }
    [System.Serializable]
    public class ddd
    {
        public int e = 50;
    }
}

