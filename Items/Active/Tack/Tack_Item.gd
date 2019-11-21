extends Area2D

const TYPE = "ACTITEM"
const NAME = 1 # 0 = null, 1 = tack

var collectible = false

func _ready():
	$Timer.start()
	$Anim.play("default")

func start_at(pos):
	set_global_position(pos)

func _on_Timer_timeout():
	collectible = true
