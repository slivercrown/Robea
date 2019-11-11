extends KinematicBody2D

const BULLET_SCENE = preload("res://Bullet.tscn")
const default_health = 100
const default_damage = 30
const TYPE = "PLAYER"

var uid = 0
var MAX_SPEED = 230 
var ACCELERATION = 6000
var motion = Vector2(0,0)
var movedir = Vector2(0,0)
var gotHurt = Vector2(0,0)
var can_shoot = true
var health = default_health
var damage = default_damage
var hitstun = 0
var knockdir = Vector2(0,0)
enum STATE {DEAD, ALIVE}
var state = STATE.ALIVE
var accumulatedDamage = [0 , 0]

func _physics_process(delta):
	$Sprite_Gun.look_at(get_global_mouse_position()) # 무기 방향 
	damage_loop()
	
	var axis = get_input_axis() 
	if(axis == Vector2.ZERO):  # 이동 방향 입력안하면 마찰 적용 	
		apply_friction(ACCELERATION * delta)
	else: # 이동 
		if hitstun == 0:
			apply_movement(axis * ACCELERATION * delta) 
		else:
			apply_knockback(knockdir.normalized() * ACCELERATION * delta *0.15 )
	motion = move_and_slide(motion)
	
	if(Input.is_action_pressed("key_shoot")):  # 무기 발사 
		shoot()
	
func shoot():
	if can_shoot and state:
		can_shoot = false
		$GunTimer.start() # 무기 연사(장전) 시간 
		var b = BULLET_SCENE.instance()
		get_parent().add_child(b)
		b.start_at($Sprite_Gun.get_global_rotation(),get_node("Sprite_Gun/FirePositon").get_global_position()) # 총알 생성 
		b.damage = damage
		b.uid = uid
		print(uid)

func get_input_axis():
	var axis = Vector2.ZERO
	if state: 
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

func apply_knockback(accel):
	motion += accel

func _on_GunTimer_timeout(): #GunTimer에서 지정한 시간이 다 되면
	can_shoot = true
		
func damage_loop():
	if hitstun > 0:
		hitstun -= 1
	for body in $Hitbox.get_overlapping_bodies():
		if hitstun == 0 and body.get("damage") != null and body.get("TYPE") != TYPE:
			health -= body.get("damage")
			$TextureProgress.updateHealth()
			if(health <= 0):
				self.state = STATE.DEAD
				Global.goto_scene("res://SceneFolder/GameOverScene.tscn")
				print(body.get("uid"))
				#TODO 내가 죽으면 마지막으로 맞은 Bullet의 uid를 서버에 질의해서 닉네임 알아오기 
			hitstun = 10
			knockdir = transform.origin - body.transform.origin
