extends KinematicBody2D

export var BULLET_SPEED = 300

const TYPE = "EBULLET"
const DAMAGE = 10

var velocity = Vector2()

func start_at(dir, pos):
	$Lifetime.start()
	set_global_rotation(dir)
	set_global_position(pos)
	velocity = Vector2(BULLET_SPEED, 0).rotated(dir)
	get_parent().get_node("ScreenShake").screen_shake(0.1,1,100)

func _ready():
	set_process(true)

func _process(delta):
	set_global_position(get_global_position() + velocity * delta)
		
func destroy():
	queue_free()

func _on_Lifetime_timeout():
	destroy()
