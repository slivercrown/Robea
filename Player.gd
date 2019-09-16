extends KinematicBody2D

var MAX_SPEED = 400
var ACCELERATION = 5000
var motion = Vector2()
var can_shoot = true
var shootAngle = 0

const BULLET_SCENE = preload("res://Bullet.tscn")


func _physics_process(delta):
	$Sprite_Gun.look_at(get_global_mouse_position())
	var axis = get_input_axis()
	if(axis == Vector2.ZERO):
		apply_friction(ACCELERATION * delta)
	else:
		apply_movement(axis * ACCELERATION * delta)
	motion = move_and_slide(motion)
	if(Input.is_action_pressed("key_shoot")):
		shoot()
	
func shoot():
	if can_shoot:
		can_shoot = false
		$GunTimer.start()
		var b = BULLET_SCENE.instance()
		get_parent().add_child(b)
		b.start_at($Sprite_Gun.get_global_rotation(),get_node("Sprite_Gun/FirePositon").get_global_position())
		
		
	
func get_input_axis():
	var axis = Vector2.ZERO
	axis.x = int(Input.is_action_pressed("ui_right")) - int(Input.is_action_pressed("ui_left"))
	axis.y = int(Input.is_action_pressed("ui_down")) - int(Input.is_action_pressed("ui_up"))
	return axis.normalized()
	
func apply_friction(amount):
	if (motion.length() > amount):
		motion -= motion.normalized() * amount
	else:
		motion = Vector2.ZERO
	
func apply_movement(accel):
	motion += accel
	motion = motion.clamped(MAX_SPEED)
	



func _on_GunTimer_timeout():
	can_shoot = true
