using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region 카드enum모음

/// <summary>
/// 카드의 타입
/// </summary>
public enum Card_Type
{

	/// <summary>
	/// 전투유닛
	/// </summary>
	Unit = 1,

	/// <summary>
	/// 마법
	/// </summary>
	Spell = 2,

	/// <summary>
	/// 타워
	/// </summary>
	Tower = 3
}
/// <summary>
/// 유닛카드 타입
/// </summary>
public enum Unit_Type
{
	/// <summary>
	/// 근접
	/// </summary>
	Melee = 1,

	/// <summary>
	/// 원거리
	/// </summary>
	Ranged = 2
}
/// <summary>
/// 카드의 진영
/// </summary>
public enum Card_Region
{
	/// <summary>
	/// 없음
	/// </summary>
	X = 0,

	/// <summary>
	/// 1
	/// </summary>
	A = 1,

	/// <summary>
	/// 2
	/// </summary>
	B = 2,

	/// <summary>
	/// 3
	/// </summary>
	C = 3
}
/// <summary>
/// 효과타입
/// </summary>
public enum Effect_Type
{
	/// <summary>
	/// 버프
	/// </summary>
	Buff =1,
	/// <summary>
	/// 없음
	/// </summary>
	None = 0,
	/// <summary>
	/// 디버프
	/// </summary>
	Debuff = -1
}

#endregion

/// <summary>
/// 카드의 기본 베이스
/// </summary> 
public abstract class Card_Base
{
	#region Card_Base프로퍼티

	/// <summary>
	/// 카드 ID
	/// </summary>
	public int CardID { get; protected set; }

	/// <summary>
	/// 카드 이름
	/// </summary>
	public string CardName { get; protected set; }

	/// <summary>
	/// 카드 타입
	/// </summary>
	public Card_Type CardType { get; protected set; }

	/// <summary>
	/// 카드 비용
	/// </summary>
	public int CardCost { get; protected set; }

	/// <summary>
	/// 카드 효과
	/// </summary>
	public string CardEffect { get; protected set; }

	/// <summary>
	/// 카드 진영
	/// </summary>
	public Card_Region CardRegion { get; set; }

	#endregion

	/// <summary>
	/// 베이스 카드 생성자
	/// </summary>
	/// <param name="id">카드 ID</param>
	/// <param name="name">카드 이름</param>
	/// <param name="type">카드 타입</param>
	/// <param name="cost">카드 비용</param>
	/// <param name="effect">카드 효과</param>
	/// <param name="region">카드 진영</param>
	protected Card_Base(int id, string name, Card_Type type, int cost, string effect, Card_Region region)
	{
		CardID = id;
		CardName = name;
		CardType = type;
		CardCost = cost;
		CardEffect = effect;
		CardRegion = region;
	}
}
/// <summary>
/// 유닛 카드 베이스
/// </summary>
public class Card_Unit : Card_Base
{
	#region Card_Unit프로퍼티

	/// <summary>
	/// 유닛카드 HP
	/// </summary>
	public int UnitCardHP { get; protected set; }

	/// <summary>
	/// 유닛카드 ATK
	/// </summary>
	public int UnitCardATK { get; protected set; }

	/// <summary>
	/// 유닛카드 DEF
	/// </summary>
	public int UnitCardDEF { get; protected set; }

	/// <summary>
	/// 유닛카드 타입
	/// </summary>
	public Unit_Type CardUnitType { get; protected set; }

	#endregion

	/// <summary>
	/// 유닛 카드 생성자
	/// </summary>
	/// <param name="id">카드의 고유 ID</param>
	/// <param name="name">카드 이름</param>
	/// <param name="cost">카드 비용</param>
	/// <param name="effect">카드 효과</param>
	/// <param name="region">카드 진영</param>
	/// <param name="uCardHP">유닛카드 HP</param>
	/// <param name="uCardATK">유닛카드 ATK</param>
	/// <param name="uCardDEF">유닛카드 DEF</param>
	public Card_Unit(int id, string name, int cost, string effect, Card_Region region, int uCardHP, int uCardATK, int uCardDEF) : base(id, name, Card_Type.Unit, cost, effect, region)
	{
		UnitCardHP = uCardHP;
		UnitCardATK = uCardATK;
		UnitCardDEF = uCardDEF;
	}
}
/// <summary>
/// 마법 카드 베이스
/// </summary>
public class Card_Spell : Card_Base
{
	/// <summary>
	/// 마법카드 ATK
	/// </summary>
	public int SpellCardATK { get; protected set; }

	/// <summary>
	/// 마법 카드 생성자
	/// </summary>
	/// <param name="id">카드의 고유 ID</param>
	/// <param name="name">카드 이름</param>
	/// <param name="cost">카드 비용</param>
	/// <param name="effect">카드 효과</param>
	/// <param name="region">카드 진영</param>
	/// <param name="sCardATK">마법카드 ATK</param>
	public Card_Spell(int id, string name, int cost, string effect, Card_Region region, int sCardATK) : base(id, name, Card_Type.Spell, cost, effect, region)
	{
		SpellCardATK = sCardATK;
	}
}
/// <summary>
/// 타워 카드 베이스
/// </summary>
public class Card_Tower : Card_Base
{
	#region Card_Tower프로퍼티

	/// <summary>
	/// 타워카드 HP 
	/// </summary>
	public int TowerCardHP { get; protected set; }

	/// <summary>
	/// 타워카드 ATK
	/// </summary>
	public int TowerCardATK { get; protected set; }

	/// <summary>
	/// 타워카드 DEF
	/// </summary>
	public int TowerCardDEF { get; protected set; }

	#endregion

	/// <summary>
	/// 타워 카드 생성자
	/// </summary>
	/// <param name="id">카드의 고유 ID</param>
	/// <param name="name">카드 이름</param>
	/// <param name="cost">카드 비용</param>
	/// <param name="effect">카드 효과</param>
	/// <param name="region">카드 진영</param>
	/// <param name="tCardHP">타워카드 HP</param>
	/// <param name="tCardATK">타워카드 ATK</param>
	/// <param name="tCardDEF">타워카드 DEF</param>
	public Card_Tower(int id, string name, int cost, string effect, Card_Region region, int tCardHP, int tCardATK, int tCardDEF) : base(id, name, Card_Type.Tower, cost, effect, region)
	{
		TowerCardHP = tCardHP;
		TowerCardATK = tCardATK;
		TowerCardDEF = tCardDEF;
	}
}
