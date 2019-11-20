extends KinematicBody2D

const BULLET_SCENE = preload("res://Bullet.tscn")
const default_health = 100
const default_damage = 1
const TYPE = "PLAYER"

var grid_position = Vector2(0,0)
var MAX_SPEED = 180 
var ACCELERATION = 6000
var motion = Vector2(0,0)
var movedir = Vector2(0,0)
var gotHurt = Vector2(0,0)
var can_shoot = true
var hitstun = 0
var knockdir = Vector2(0,0)
enum STATE {IDLE, ATTACK}
var state = STATE.IDLE # 상태 
var sprite_flip = false # 스프라이트 방향 

var attacking = false

var health = default_health
var DAMAGE = default_damage
var SPEED = MAX_SPEED

func _physics_process(delta):
	$Sprite_Gun.look_at(get_global_mouse_position()) # 무기 방향
	damage_loop(delta)
	check_animation_loop()
	animation_loop()
	var axis = get_input_axis() 
	if(axis == Vector2.ZERO):  # 이동 방향 입력안하면 마찰 적용 	
		if hitstun == 0:
			apply_friction(ACCELERATION * delta)
	else: # 이동 
		if hitstun == 0:
			apply_movement(axis * ACCELERATION * delta) 
		else:
			apply_knockback(knockdir.normalized() * ACCELERATION * delta *0.15 )
	motion = move_and_slide(motion)

	if pow(get_node("../JoystickAim/Joystick").output[0], 2) + pow(get_node("../JoystickAim/Joystick").output[1], 2) >= 0.7:
		shoot()
	else: 
		state = STATE.IDLE
	
	
func shoot():
	if can_shoot :
		can_shoot = false
		state = STATE.ATTACK
		$GunTimer.start() # 무기 연사(장전) 시간 
		var b = BULLET_SCENE.instance()
		get_parent().add_child(b)
		
		var aim = get_node("../JoystickAim/Joystick").output
		var aimFloat = aim.angle()
		if aim[0] < 0:
			$Sprite_Player.set_flip_h(true)
			sprite_flip = true
			b.start_at(aimFloat,Vector2(global_position.x-20,global_position.y-4)) # 총알 생성 
		elif aim[0] > 0:
			$Sprite_Player.set_flip_h(false)
			sprite_flip = false
			b.start_at(aimFloat,Vector2(global_position.x+20,global_position.y-4)) # 총알 생성 

func get_input_axis():
	var axis = Vector2.ZERO
	axis = get_node("../JoystickMoving/Joystick").output
	if(axis[0] < 0): 
		$Sprite_Player.set_flip_h(true)
		sprite_flip = true
	elif(axis[0] > 0):
		$Sprite_Player.set_flip_h(false)
		sprite_flip = false 
	return axis.normalized() # 벡터값을 1로 만들어줌 
	
func apply_friction(amount):
	if (motion.length() > amount): 
		motion -= motion.normalized() * amount
	else:
		motion = Vector2.ZERO
	
func apply_movement(accel):
	motion += accel
	motion = motion.clamped(MAX_SPEED)

func apply_knockback(accel):
	motion += accel

func _on_GunTimer_timeout(): #GunTimer에서 지정한 시간이 다 되면
	can_shoot = true
	
func takeDamage(): 
	$TextureProgress.updateHealth()
		
func damage_loop(delta):
	if hitstun > 0:
		hitstun -= 1
	for body in $Hitbox.get_overlapping_bodies():
		if hitstun == 0 and body.get("DAMAGE") != null and body.get("TYPE") == "ENEMY":
			health -= body.get("DAMAGE")
			$TextureProgress.updateHealth()
			hitstun = 10
			knockdir = Vector2(global_position.x - body.global_position.x, global_position.y - body.global_position.y)
			apply_knockback(knockdir.normalized() * ACCELERATION * delta * 0.2 )
			
func animation_loop():
	match state:
		STATE.IDLE:
			$Sprite_Player.play("Idle")
			$Sprite_Player.set_speed_scale(1)
			if sprite_flip:
				$Sprite_Player.set_flip_h(true)
			else:
				$Sprite_Player.set_flip_h(false)
		STATE.ATTACK:
			$Sprite_Player.play("Attack")
			$Sprite_Player.set_speed_scale(1)
			if sprite_flip:
				$Sprite_Player.set_flip_h(true)
			else:
				$Sprite_Player.set_flip_h(false)

func check_animation_loop():
	if $Sprite_Player.animation == "Attack" && $Sprite_Player.frame == $Sprite_Player.frames.get_frame_count("Attack")-1:
			if !Input.is_action_pressed("key_shoot"):
				state = STATE.IDLE

