extends Node2D

func start_at(pos):
	$Sprite.play("default")
	set_process(true)
	set_global_position(pos)
	

func _on_Sprite_animation_finished():
	queue_free()
