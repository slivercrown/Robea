extends Area2D

const TYPE = "ITEM"
const NAME = 0 # 0 = eraser, 1 = glue

var collectible = false

func _ready():
	$Timer.start()
	$Anim.play("default")

func start_at(pos):
	set_global_position(pos)

func _on_Timer_timeout():
	collectible = true
