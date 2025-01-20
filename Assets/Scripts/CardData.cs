using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    Unit,   //전투유닛
    Spell,  //마법카드
    Tower   //건물
}

[CreateAssetMenu(fileName = "NewCard", menuName = "Card/Create New Card")]
public class CardData : ScriptableObject
{
    public string cardName;
    public CardType cardType;
    public int cardCost;
    public int cardHealth;
    public int cardAttack;
    public int cardDeffence;
    [TextArea]
    public string cardText;
}
