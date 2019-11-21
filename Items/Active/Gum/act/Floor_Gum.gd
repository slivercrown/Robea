extends Area2D

const TYPE = "FLOORGUM"

func start_at(pos):
	$Lifetime.start()
	set_rotation_degrees(randi() % 359)
	set_global_position(pos)

func _on_Lifetime_timeout():
	queue_free()
