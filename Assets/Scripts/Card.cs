using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region ī��enum����

/// <summary>
/// ī���� Ÿ��
/// </summary>
public enum Card_Type
{

	/// <summary>
	/// ��������
	/// </summary>
	Unit = 1,

	/// <summary>
	/// ����
	/// </summary>
	Spell = 2,

	/// <summary>
	/// Ÿ��
	/// </summary>
	Tower = 3
}
/// <summary>
/// ����ī�� Ÿ��
/// </summary>
public enum Unit_Type
{
	/// <summary>
	/// ����
	/// </summary>
	Melee = 1,

	/// <summary>
	/// ���Ÿ�
	/// </summary>
	Ranged = 2
}
/// <summary>
/// ī���� ����
/// </summary>
public enum Card_Region
{
	/// <summary>
	/// ����
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
/// ȿ��Ÿ��
/// </summary>
public enum Effect_Type
{
	/// <summary>
	/// ����
	/// </summary>
	Buff =1,
	/// <summary>
	/// ����
	/// </summary>
	None = 0,
	/// <summary>
	/// �����
	/// </summary>
	Debuff = -1
}

#endregion

/// <summary>
/// ī���� �⺻ ���̽�
/// </summary> 
public abstract class Card_Base
{
	#region Card_Base������Ƽ

	/// <summary>
	/// ī�� ID
	/// </summary>
	public int CardID { get; protected set; }

	/// <summary>
	/// ī�� �̸�
	/// </summary>
	public string CardName { get; protected set; }

	/// <summary>
	/// ī�� Ÿ��
	/// </summary>
	public Card_Type CardType { get; protected set; }

	/// <summary>
	/// ī�� ���
	/// </summary>
	public int CardCost { get; protected set; }

	/// <summary>
	/// ī�� ȿ��
	/// </summary>
	public string CardEffect { get; protected set; }

	/// <summary>
	/// ī�� ����
	/// </summary>
	public Card_Region CardRegion { get; set; }

	#endregion

	/// <summary>
	/// ���̽� ī�� ������
	/// </summary>
	/// <param name="id">ī�� ID</param>
	/// <param name="name">ī�� �̸�</param>
	/// <param name="type">ī�� Ÿ��</param>
	/// <param name="cost">ī�� ���</param>
	/// <param name="effect">ī�� ȿ��</param>
	/// <param name="region">ī�� ����</param>
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
/// ���� ī�� ���̽�
/// </summary>
public class Card_Unit : Card_Base
{
	#region Card_Unit������Ƽ

	/// <summary>
	/// ����ī�� HP
	/// </summary>
	public int UnitCardHP { get; protected set; }

	/// <summary>
	/// ����ī�� ATK
	/// </summary>
	public int UnitCardATK { get; protected set; }

	/// <summary>
	/// ����ī�� DEF
	/// </summary>
	public int UnitCardDEF { get; protected set; }

	/// <summary>
	/// ����ī�� Ÿ��
	/// </summary>
	public Unit_Type CardUnitType { get; protected set; }

	#endregion

	/// <summary>
	/// ���� ī�� ������
	/// </summary>
	/// <param name="id">ī���� ���� ID</param>
	/// <param name="name">ī�� �̸�</param>
	/// <param name="cost">ī�� ���</param>
	/// <param name="effect">ī�� ȿ��</param>
	/// <param name="region">ī�� ����</param>
	/// <param name="uCardHP">����ī�� HP</param>
	/// <param name="uCardATK">����ī�� ATK</param>
	/// <param name="uCardDEF">����ī�� DEF</param>
	public Card_Unit(int id, string name, int cost, string effect, Card_Region region, int uCardHP, int uCardATK, int uCardDEF) : base(id, name, Card_Type.Unit, cost, effect, region)
	{
		UnitCardHP = uCardHP;
		UnitCardATK = uCardATK;
		UnitCardDEF = uCardDEF;
	}
}
/// <summary>
/// ���� ī�� ���̽�
/// </summary>
public class Card_Spell : Card_Base
{
	/// <summary>
	/// ����ī�� ATK
	/// </summary>
	public int SpellCardATK { get; protected set; }

	/// <summary>
	/// ���� ī�� ������
	/// </summary>
	/// <param name="id">ī���� ���� ID</param>
	/// <param name="name">ī�� �̸�</param>
	/// <param name="cost">ī�� ���</param>
	/// <param name="effect">ī�� ȿ��</param>
	/// <param name="region">ī�� ����</param>
	/// <param name="sCardATK">����ī�� ATK</param>
	public Card_Spell(int id, string name, int cost, string effect, Card_Region region, int sCardATK) : base(id, name, Card_Type.Spell, cost, effect, region)
	{
		SpellCardATK = sCardATK;
	}
}
/// <summary>
/// Ÿ�� ī�� ���̽�
/// </summary>
public class Card_Tower : Card_Base
{
	#region Card_Tower������Ƽ

	/// <summary>
	/// Ÿ��ī�� HP 
	/// </summary>
	public int TowerCardHP { get; protected set; }

	/// <summary>
	/// Ÿ��ī�� ATK
	/// </summary>
	public int TowerCardATK { get; protected set; }

	/// <summary>
	/// Ÿ��ī�� DEF
	/// </summary>
	public int TowerCardDEF { get; protected set; }

	#endregion

	/// <summary>
	/// Ÿ�� ī�� ������
	/// </summary>
	/// <param name="id">ī���� ���� ID</param>
	/// <param name="name">ī�� �̸�</param>
	/// <param name="cost">ī�� ���</param>
	/// <param name="effect">ī�� ȿ��</param>
	/// <param name="region">ī�� ����</param>
	/// <param name="tCardHP">Ÿ��ī�� HP</param>
	/// <param name="tCardATK">Ÿ��ī�� ATK</param>
	/// <param name="tCardDEF">Ÿ��ī�� DEF</param>
	public Card_Tower(int id, string name, int cost, string effect, Card_Region region, int tCardHP, int tCardATK, int tCardDEF) : base(id, name, Card_Type.Tower, cost, effect, region)
	{
		TowerCardHP = tCardHP;
		TowerCardATK = tCardATK;
		TowerCardDEF = tCardDEF;
	}
}
