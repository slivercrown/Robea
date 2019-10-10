extends KinematicBody2D

const BULLET_SCENE = preload("res://Bullet.tscn")
const default_health = 100
const default_damage = 10

var MAX_SPEED = 230 
var ACCELERATION = 6000
var motion = Vector2()
var can_shoot = true
var health = default_health
enum STATE {DEAD, ALIVE}
var state = STATE.ALIVE

func _physics_process(delta):
	$Sprite_Gun.look_at(get_global_mouse_position()) # 무기 방향 
	
	var axis = get_input_axis() 
	if(axis == Vector2.ZERO):  # 이동 방향 입력안하면 마찰 적용 	
		apply_friction(ACCELERATION * delta)
	else: # 이동 
		apply_movement(axis * ACCELERATION * delta) 
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
		takeDamage()
		

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


func _on_GunTimer_timeout(): #GunTimer에서 지정한 시간이 다 되면
	can_shoot = true
	
	
func takeDamage(): 
	health -= 10
	$TextureProgress.updateHealth()
	if(health <= 0):
		self.state = STATE.DEAD
		#get_tree().change_scene("res://SceneFolder/GameOverScene.tscn")
		Global.goto_scene("res://SceneFolder/GameOverScene.tscn")