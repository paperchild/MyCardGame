using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������ Ÿ���� ����
/// </summary>
public enum Near_Tile_Dir
{
	/// <summary>
	/// ��
	/// </summary>
	Up = 1,
	/// <summary>
	/// �Ʒ�
	/// </summary>
	Down = 2,
	/// <summary>
	/// ����
	/// </summary>
	Left = 3,
	/// <summary>
	/// ������
	/// </summary>
	Right = 4,
}

/// <summary>
/// Ÿ���� ����Ÿ��
/// </summary>
public enum Tile_Type
{
	/// <summary>
	/// �� Ÿ��
	/// </summary>
	MyTile = 1,
	/// <summary>
	/// �߸� Ÿ��
	/// </summary>
	NoneTile = 0,
	/// <summary>
	/// �� Ÿ��
	/// </summary>
	EnemyTile = -1
}
public class Tile
{
	//���߿� �߰��ؾ��Ҽ��� �ִ� ��.
	//ī�� ���� ���� bool

	#region Tile������Ƽ

	/// <summary>
	/// Ÿ�� ���� �ѹ�
	/// </summary>
	int TileIndexNum { get; set; }
	/// <summary>
	/// Ÿ����ǥ
	/// </summary>
	public Vector2Int TileLocation { get; protected set; }
	/// <summary>
	/// Ÿ�Ͽ� ����� ī��
	/// </summary>
	public Card_Base CardOnTile { get; protected set; }
	/// <summary>
	/// ����Ÿ�Ϲ迭
	/// </summary>
	public Dictionary<Near_Tile_Dir, Tile> NearTile { get; protected set; }

	/// <summary>
	/// Ÿ�Ͽ� ����� ȿ��
	/// </summary>
	public Dictionary<Effect_Type, string> TileStatus { get; protected set; }

	/// <summary>
	/// Ÿ���� ����Ÿ��
	/// </summary>
	public Tile_Type TileType { get; protected set; }


	#endregion

	/// <summary>
	/// Ÿ�� ������
	/// </summary>
	/// <param name="position">Ÿ���� ��ġ</param>
	/// <param name="indexnum">Ÿ���� ������ȣ</param>
	/// <remarks>ù��° ���� �� ����,
	/// ������ ���� ��� �����ΰ��� ������.</remarks>
	public Tile(Vector2Int position, int indexnum)
	{
		/*
		//�ٸ� ��� �ʿ��ѵ�
		//Ÿ�� Ÿ�� �ʱ�ȭ
		if (position.y == 0)
			TileType = Tile_Type.MyTile;
		else if (position.y == maxRow - 1)
			TileType = Tile_Type.EnemyTile;
		else
			TileType = Tile_Type.NoneTile;
		*/
		TileLocation = position;
		TileIndexNum = indexnum;

		//�ʱ�ȭ �ؾ��ϱ� ������ �� ������ �ʱ�ȭ
		NearTile = new Dictionary<Near_Tile_Dir, Tile>();
		TileStatus = new Dictionary<Effect_Type, string>();
	}

	/// <summary>
	/// ����Ÿ�� �߰�
	/// </summary>
	/// <param name="dir">����Ÿ�� ����</param>
	/// <param name="nearTile">���� Ÿ��</param>
	public void AddNearTile(Near_Tile_Dir dir, Tile nearTile)
	{
		NearTile.Add(dir, nearTile);
	}

	/// <summary>
	/// Ÿ�� Ÿ�� �߰�
	/// </summary>
	/// <param name="type">Ÿ�� Ÿ��</param>
	public void AddTile_Type(Tile_Type type)
	{
		TileType = type;
	}

	/// <summary>
	/// ī�� �߰�
	/// </summary>
	/// <param name="card">ī��</param>
	public void AddCard(Card_Base card)
	{
		//CardOnTile= new Card_Base(card);
	}

}
