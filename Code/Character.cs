using Godot;
using System;
using System.Numerics;

public partial class Character : Node
{
    private String name; 
    //Base Points
    private float hitPoints;
    private float manaPoints;
    //Damage Indicators
    private float damage;

    private CharacterBody3D characterBody3D;

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

    public void Movement(double delta, Godot.Vector3 Velocity, int Speed){

         var direction = Godot.Vector3.Zero;

         if(Input.IsActionPressed("Forward")){
            direction.Z -= 1;
        }
        if (Input.IsActionPressed("Backward")){
            direction.Z += 1;
        }
        if(Input.IsActionPressed("Right")){
            direction.X += 1;
        }
        if(Input.IsActionPressed("Left")){
            direction.X -= 1;
        }
            
        if(direction != Godot.Vector3.Zero){
            direction = direction.Normalized();
            GetNode<Node3D>("Pivot").Basis = Basis.LookingAt(direction);
        }

        Velocity.X = direction.X * Speed;
        Velocity.Z = direction.Z * Speed;

        characterBody3D.MoveAndSlide();
    }


}
