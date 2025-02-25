using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
	Tile[][] tiles;
	Tile MyCastleTile;
	Tile EnemyCastleTile;
	int TileColNum { get; set; } = 5;
	int TileRowNum { get; set; } = 3;

	private void Start()
	{
		AddTiles();
		SetNearTiles();
		SetCastleTile();
	}

	/// <summary>
	/// Ÿ�� �迭 �߰�
	/// </summary>
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

	/// <summary>
	/// Ÿ�� �迭�� ����Ÿ�� �߰�
	/// </summary>
	void SetNearTiles()
	{
		//�� Ÿ��
		for (int row = 0; row < TileRowNum - 1; ++row)
		{
			for (int col = 0; col < TileColNum; ++col)
			{
				tiles[col][row].AddNearTile(Near_Tile_Dir.Up, tiles[col][row + 1]);
			}
		}

		//�Ʒ� Ÿ��
		for (int row = 1; row < TileRowNum; ++row)
		{
			for (int col = 0; col < TileColNum; ++col)
			{
				tiles[col][row].AddNearTile(Near_Tile_Dir.Down, tiles[col][row - 1]);
			}
		}

		//�� Ÿ��
		for (int row = 0; row < TileRowNum; ++row)
		{
			for (int col = 1; col < TileColNum; ++col)
			{
				tiles[col][row].AddNearTile(Near_Tile_Dir.Left, tiles[col - 1][row]);
			}
		}

		//���� Ÿ��
		for (int row = 0; row < TileRowNum; ++row)
		{
			for (int col = 0; col < TileColNum - 1; ++col)
			{
				tiles[col][row].AddNearTile(Near_Tile_Dir.Right, tiles[col + 1][row]);
			}
		}
	}

	/// <summary>
	/// �� Ÿ�� �߰�
	/// </summary>
	void SetCastleTile()
	{
		MyCastleTile = new Tile(new Vector2Int(3, -1), 1000);
		EnemyCastleTile = new Tile(new Vector2Int(3, TileRowNum + 1), 2000);
		MyCastleTile.AddTile_Type(Tile_Type.MyTile);
		EnemyCastleTile.AddTile_Type(Tile_Type.EnemyTile);

		SetCastleNearTile();

	}
	/// <summary>
	/// �� ���� Ÿ�� �߰�
	/// </summary>
	void SetCastleNearTile()
	{
		MyCastleTile.AddNearTile(Near_Tile_Dir.Up, tiles[3][0]);
		EnemyCastleTile.AddNearTile(Near_Tile_Dir.Down, tiles[3][TileRowNum - 1]);
	}
}