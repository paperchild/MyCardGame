using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 인접한 타일의 방향
/// </summary>
public enum Near_Tile_Dir
{
	/// <summary>
	/// 위
	/// </summary>
	Up = 1,
	/// <summary>
	/// 아래
	/// </summary>
	Down = 2,
	/// <summary>
	/// 왼쪽
	/// </summary>
	Left = 3,
	/// <summary>
	/// 오른쪽
	/// </summary>
	Right = 4,
}

/// <summary>
/// 타일의 진영타입
/// </summary>
public enum Tile_Type
{
	/// <summary>
	/// 내 타일
	/// </summary>
	MyTile = 1,
	/// <summary>
	/// 중립 타일
	/// </summary>
	NoneTile = 0,
	/// <summary>
	/// 적 타일
	/// </summary>
	EnemyTile = -1
}
public class Tile
{
	//나중에 추가해야할수도 있는 것.
	//카드 존재 유무 bool

	#region Tile프로퍼티

	/// <summary>
	/// 타일 고유 넘버
	/// </summary>
	int TileIndexNum { get; set; }
	/// <summary>
	/// 타일좌표
	/// </summary>
	public Vector2Int TileLocation { get; protected set; }
	/// <summary>
	/// 타일에 적용된 카드
	/// </summary>
	public Card_Base CardOnTile { get; protected set; }
	/// <summary>
	/// 인접타일배열
	/// </summary>
	public Dictionary<Near_Tile_Dir, Tile> NearTile { get; protected set; }

	/// <summary>
	/// 타일에 적용된 효과
	/// </summary>
	public Dictionary<Effect_Type, string> TileStatus { get; protected set; }

	/// <summary>
	/// 타일의 진영타입
	/// </summary>
	public Tile_Type TileType { get; protected set; }


	#endregion

	/// <summary>
	/// 타일 생성자
	/// </summary>
	/// <param name="position">타일의 위치</param>
	/// <param name="indexnum">타일의 고유번호</param>
	/// <remarks>첫번째 행은 내 진영,
	/// 마지막 행은 상대 진영인것을 전제함.</remarks>
	public Tile(Vector2Int position, int indexnum)
	{
		/*
		//다른 방법 필요한듯
		//타일 타입 초기화
		if (position.y == 0)
			TileType = Tile_Type.MyTile;
		else if (position.y == maxRow - 1)
			TileType = Tile_Type.EnemyTile;
		else
			TileType = Tile_Type.NoneTile;
		*/
		TileLocation = position;
		TileIndexNum = indexnum;

		//초기화 해야하기 때문에 빈 값으로 초기화
		NearTile = new Dictionary<Near_Tile_Dir, Tile>();
		TileStatus = new Dictionary<Effect_Type, string>();
	}

	/// <summary>
	/// 인접타일 추가
	/// </summary>
	/// <param name="dir">인접타일 방향</param>
	/// <param name="nearTile">인접 타일</param>
	public void AddNearTile(Near_Tile_Dir dir, Tile nearTile)
	{
		NearTile.Add(dir, nearTile);
	}

	/// <summary>
	/// 타일 타입 추가
	/// </summary>
	/// <param name="type">타일 타입</param>
	public void AddTile_Type(Tile_Type type)
	{
		TileType = type;
	}

	/// <summary>
	/// 카드 추가
	/// </summary>
	/// <param name="card">카드</param>
	public void AddCard(Card_Base card)
	{
		//CardOnTile= new Card_Base(card);
	}

}
