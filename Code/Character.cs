using Godot;
using System;

public partial class Character : Node
{
    private String name; 
    //Base Points
    private float hitPoints;
    private float manaPoints;
    //Damage Indicators
    private float damage;

    public Character(){}
    public Character(String name, float hitPoints, float manaPoints, float damage){
        this.name = name;
        this.hitPoints = hitPoints;
        this.manaPoints = manaPoints;
        this.damage = damage;
    }
    
    public String _Name
    {
        get{return this.name;}
        set{this.name = value;}
    }
    public float HitPoints
    {
        get{return this.hitPoints;}
        set{this.hitPoints = value;}
    }
    public float ManaPoints
    {
        get {return this.manaPoints;}
        set {this.manaPoints=value;}
    }
    public float Damage
    {
        get {return this.damage;}
        set {this.damage = value;}
    }
}
