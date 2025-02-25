using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
	Tile[][] tiles;
	int TileColNum { get; set; }
	int TileRowNum { get; set; }

	private void Start()
	{
		AddTiles();
		SetNearTiles();
	}

	void AddTiles()
	{
		int num = 0;
		for (int row = 0; row < TileRowNum; ++row)
		{
			for (int col = 0; col < TileColNum; ++col)
			{
				tiles[col][row] = new Tile(new Vector2Int(col, row), num++);
				if (row == 0)
					tiles[col][row].AddTile_Type(Tile_Type.MyTile);
				else if (row == TileRowNum - 1)
					tiles[col][row].AddTile_Type(Tile_Type.EnemyTile);
				else
					tiles[col][row].AddTile_Type(Tile_Type.NoneTile);
			}
		}
	}

	void SetNearTiles()
	{
		//위 타일
		for (int row = 0; row < TileRowNum - 1; ++row)
		{
			for (int col = 0; col < TileColNum; ++col)
			{
				tiles[row][col].AddNearTile(Near_Tile_Dir.Up, tiles[row + 1][col]);
			}
		}

		//아래 타일
		for (int row = 1; row < TileRowNum; ++row)
		{
			for (int col = 0; col < TileColNum; ++col)
			{
				tiles[row][col].AddNearTile(Near_Tile_Dir.Down, tiles[row - 1][col]);
			}
		}

		//왼 타일
		for (int row = 0; row < TileRowNum; ++row)
		{
			for (int col = 1; col < TileColNum; ++col)
			{
				tiles[row][col].AddNearTile(Near_Tile_Dir.Left, tiles[row][col - 1]);
			}
		}

		//오른 타일
		for (int row = 0; row < TileRowNum; ++row)
		{
			for (int col = 0; col < TileColNum - 1; ++col)
			{
				tiles[row][col].AddNearTile(Near_Tile_Dir.Right, tiles[row][col + 1]);
			}
		}
	}
}