extends KinematicBody2D

var speed = 250
var velocity = Vector2()



#var new_pos = pos - origin

func _physics_process(delta):

 velocity.x += 1.5
 move_and_collide(velocity * delta)