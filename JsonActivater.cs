using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonActivater : MonoBehaviour
{
    const int MapRow = 8;
    const int MapColumn = 17;

    public SaveData.SampleMapData SMD = new SaveData.SampleMapData();
    public int[] celleffectNumArr = new int[136]
                               {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                0, 0,10,23,10,10,10, 0,60,10,10,40, 0, 0, 0, 0, 0,
                                0, 0,40, 0, 0, 0,10, 0, 0, 0, 0,10, 0, 0, 0, 0, 0,
                                0, 0,10, 0,10,10,25,10,10, 0, 0,32, 0, 0, 0, 0, 0,
                                0, 0,32, 0,40, 0, 0, 0,40, 0, 0,25, 0, 0, 0, 0, 0,
                                0, 0,10, 0,10, 0, 0, 0,25, 0, 0,40, 0, 0, 0, 0, 0,
                               50,10,10,33,10,40,10,25,10,10,33,10, 0, 0, 0, 0, 0};

    public SaveData.Junction[] junctionArr = new SaveData.Junction[7];
    public List<int>[] junctionNextjunction = new List<int>[100];
    public int[] aCell = new int[2];
    public List<int[]> CellCordinate = new List<int[]>();
    public int junctionCount;


    public void Start()
    {
        SetMapData();
        for (int i = 0; i < 6; i++)
        {
            SMD.junctionList.Add(junctionArr[i]);
        }

        Debug.Log(JsonUtility.ToJson(SMD));
    }

    public void SetMapData()
    {
        junctionCount = 7;

        junctionNextjunction[0] = new List<int>() { 1, 2 };
        junctionNextjunction[1] = new List<int>() { 4 };
        junctionNextjunction[2] = new List<int>() { 3, 5 };
        junctionNextjunction[3] = new List<int>() { 4 };
        junctionNextjunction[4] = new List<int>() { 6 };
        junctionNextjunction[5] = new List<int>() { 6 };
        junctionNextjunction[6] = new List<int>() { 0 };

        for (int i = 0; i < MapRow; i++)
        {
            for (int j = 0; j < MapColumn; j++)
            {
                int[] aCell = new int[2] {i, j};
                CellCordinate.Add(aCell);
            }
        }

        
    }
    //void Start()
    //{


    //    //Intojson.aaa a = new Intojson.aaa();
    //    //a.ValueIntoArr();
    //    //Debug.Log(JsonUtility.ToJson(a));
    //}
}
