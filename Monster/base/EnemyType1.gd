extends "res://Monster/base/entity.gd"

var movetimer_length = 15
var movetimer = 0
var player = null

func _ready():
	$Animation.play("default")
	movedir = dir.rand()
	
func _physics_process(delta):
	movement_loop()
	damage_loop()
	if player == null:
		return
	
	var vec_to_player = player.global_position - global_position
	vec_to_player = vec_to_player.normalized()
