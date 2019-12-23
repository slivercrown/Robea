extends KinematicBody2D

var speed = 250
var velocity = Vector2()

func _physics_process(delta):

 velocity.x += 1.5
 move_and_collide(velocity * delta)