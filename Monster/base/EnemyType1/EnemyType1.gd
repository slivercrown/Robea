extends KinematicBody2D

var SPEED = 40

const TYPE = "ENEMY"
const DAMAGE = 10

var hitstun = 0
var health = 10

var target = null
var movedir = Vector2(0,0)
var knockdir = Vector2(0,0)
var spritedir = "down"

var limit_l = 0
var limit_r = 0
var limit_u = 0
var limit_d = 0

var movetimer_length = 15
var movetimer = 0
var grid_position = Vector2(0,0)

signal minus_count
signal plus_count
	

func _ready():
	$Animation.play("default")
	$DirTimer.start()
	movedir = Vector2(rand_range(-1, 1), rand_range(-1, 1))
	emit_signal("plus_count")

	
	
func _physics_process(delta):
	movement_loop()
	damage_loop()
	for body in $ChaseArea.get_overlapping_bodies():
		if body.get("TYPE") == "PLAYER" and body.grid_position == grid_position:
			movedir = Vector2(body.global_position.x-global_position.x, body.global_position.y-global_position.y)
			target = body
			
	if health <= 0:
		emit_signal("minus_count")
		queue_free()

func start_at(pos):
	set_position(pos)


func movement_loop():
	var motion
	if global_position.x <= limit_l || global_position.x >= limit_r || global_position.y >= limit_d || global_position.y <= limit_u:
			hitstun = 30
			movedir = -movedir
			knockdir = movedir
	if hitstun == 0:
		if target:
			var n1 = Vector2(target.global_position.x,target.global_position.y)
			var n2 = Vector2(global_position.x,global_position.y)
			SPEED = 50
			motion = movedir.normalized() * SPEED
		else:
			SPEED = 25
			motion = movedir.normalized() * SPEED
	else:
		motion = knockdir.normalized() * SPEED * 3

	move_and_slide(motion, Vector2(0,0))
	
func spritedir_loop():
	match movedir:
		Vector2(-1,0):
			spritedir = "left"
		Vector2(1,0):
			spritedir = "right"
		Vector2(0,-1):
			spritedir = "up"
		Vector2(0,1):
			spritedir = "down"
			
func anim_switch(animation):
	var newanim = str(animation, spritedir)
	if $anim.current_animation != newanim:
		$anim.play(newanim)

func damage_loop():
	if hitstun > 0:
		hitstun -= 1
	for body in $Hitbox.get_overlapping_bodies():
		if hitstun == 0 and body.get("DAMAGE") != null and body.get("TYPE") == "PLAYER":
			hitstun = 10
			knockdir = Vector2(global_position.x - body.global_position.x, global_position.y - body.global_position.y)
	
	for body in $Hitbox.get_overlapping_bodies():
		if hitstun == 0 and body.get("DAMAGE") != null and body.get("TYPE") == "BULLET":
			health -= body.get("DAMAGE")
			hitstun = 5
			SPEED = 0
			body.queue_free()	



	
	

func _on_DirTimer_timeout():
	movedir = Vector2(rand_range(-1, 1), rand_range(-1, 1))
