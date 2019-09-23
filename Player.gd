extends KinematicBody2D

var MAX_SPEED = 200 
var ACCELERATION = 5000
var motion = Vector2()
var stage_size = Vector2(640,360) 
var can_shoot = true

const BULLET_SCENE = preload("res://Bullet.tscn")


func _physics_process(delta):
	$Sprite_Gun.look_at(get_global_mouse_position()) # 무기 방향 
	
	var axis = get_input_axis() 
	if(axis == Vector2.ZERO):  # 이동 방향 입력안하면 마찰 적용 
		apply_friction(ACCELERATION * delta)
	else: # 이동 
		apply_movement(axis * ACCELERATION * delta) 
	motion = move_and_slide(motion)
	#position.x = clamp(position.x, 0, stage_size.x) # 이동 한계점 설정 
	#position.y = clamp(position.y, 0, stage_size.y)
	
	if(Input.is_action_pressed("key_shoot")):  # 무기 발사 
		shoot()
	
func shoot():
	if can_shoot:
		can_shoot = false
		$GunTimer.start() # 무기 연사(장전) 시간 
		var b = BULLET_SCENE.instance()
		get_parent().add_child(b)
		b.start_at($Sprite_Gun.get_global_rotation(),get_node("Sprite_Gun/FirePositon").get_global_position()) # 총알 생성 
		
		
	
func get_input_axis():
	var axis = Vector2.ZERO
	axis.x = int(Input.is_action_pressed("ui_right")) - int(Input.is_action_pressed("ui_left")) # right - left로 좌우 방향 결정
	axis.y = int(Input.is_action_pressed("ui_down")) - int(Input.is_action_pressed("ui_up")) # down - up으로 상하 방향 결정 
	return axis.normalized() # 벡터값을 1로 만들어줌 
	
func apply_friction(amount):
	if (motion.length() > amount): 
		motion -= motion.normalized() * amount
	else:
		motion = Vector2.ZERO
	
func apply_movement(accel):
	motion += accel
	motion = motion.clamped(MAX_SPEED)
	



func _on_GunTimer_timeout(): #GunTimer에서 지정한 시간이 다 되면
	can_shoot = true
