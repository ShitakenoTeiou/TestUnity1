using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SaveData
{
    [System.Serializable]
    public class SampleMapData
    {
        public List<Junction> junctionList = new List<Junction>();
    }

    [System.Serializable]
    public class Junction
    {
        public List<int> holdingCellNum = new List<int>();
        public List<Cell> holdingCellArr = new List<Cell>();
        public List<int> nextJunctionArr = new List<int>();
        Cell[] holdedCell = new Cell[136];
        
        public Junction(List<int> holdingCellNum, List<int> nextJunctionArr,List<int> cellCharacterArr)
        {
            this.holdingCellNum = holdingCellNum;
            this.nextJunctionArr = nextJunctionArr;

            for (int i = 0; i < holdingCellNum.Count; i++)
            {
                holdedCell[i] = new Cell(holdingCellNum[i], cellCharacterArr[i]);
                holdingCellArr.Add(holdedCell[i]);
            }
                
        }
    }

    [System.Serializable]
    public class Cell
    {
        public int[] cordinates = new int[2];
        public int effectNum;
        public int nextCellNum;

        public Cell(int PositionNum ,int effectNum)
        {
            int RowNum;
            int ColumnNum;
            RowNum = (PositionNum % 8) + 1;
            ColumnNum = ((PositionNum - (RowNum - 1)) / 8) + 1;
            cordinates[0] = RowNum;
            cordinates[1] = ColumnNum;
            this.effectNum = effectNum;
        }
    }
}

