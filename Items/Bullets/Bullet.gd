extends KinematicBody2D


export var BULLET_SPEED = 250

const TYPE = "BULLET"
const DAMAGE = 10

var glue = false
var eraser = false

var parent = null

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

func _on_Hitbox_body_entered(body):
	if body.get_name() == "TileMap":
		if eraser:
			if get_global_rotation_degrees() == 0 || get_global_rotation_degrees() == 90 || get_global_rotation_degrees() == 180 || get_global_rotation_degrees() == -90:
				set_global_rotation_degrees(-get_global_rotation_degrees())
			elif get_position().x > 448:
				set_global_rotation_degrees(get_global_rotation_degrees() + 90*sign(get_global_rotation_degrees()))
			elif get_position().x < 32:
				set_global_rotation_degrees(get_global_rotation_degrees() - 90*sign(get_global_rotation_degrees()))
			elif  get_position().y > 238 || get_position().y < 32:
				set_global_rotation_degrees(-get_global_rotation_degrees())
			
			
			velocity = Vector2(BULLET_SPEED, 0).rotated(get_global_rotation())
		else:
			queue_free()
