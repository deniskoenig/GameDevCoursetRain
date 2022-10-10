using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Vererbungsmethode, verhindert es beispielsweise einen NPC mit beiden Eigenschaften (Player, Enemy) zu nutzen
class Character
{
    Vector2 locomotion;
    int attack;
    int health;
}

class Player : Character
{
    void PlayerControl() { }
    
    void Upgradeable() { }

}

class Enemy : Character
{
    void AIControl() { }

    void HostileToPlayer() { }
}

//Komponentenmethode, erlaubt alle Eigenschaften seperat an jedes Gameobject hinzuzufügen ohne auf Vererbungsstränge zu achten

public class CompositeoverInheritance : MonoBehaviour
{
    [SerializeField] int live;
    [SerializeField] int attack;

    void calculateDMG() { }
}
