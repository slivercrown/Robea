extends KinematicBody2D

var SPEED = 150

const TYPE = "ENEMY"
const DAMAGE = 10

var hitstun = 0
var health = 10

var velocity = Vector2()
var movedir = Vector2()
var knockdir = Vector2()
var spritedir = "down"

var GLUE_VAR = 1

var hitmask = 1
var hitTimer = 0

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
	randomize()
	$Animation.play("default")
	velocity = Vector2(150, 0).rotated(randi() % 359)
	emit_signal("plus_count")
	
func _physics_process(delta):
	movement_loop(delta)
	damage_loop()
	if health <= 0:
		emit_signal("minus_count")
		queue_free()
	

func movement_loop(delta):
	var motion
	var collision = move_and_collide(velocity * delta * GLUE_VAR)
			
	if collision:
		velocity = velocity.bounce(collision.normal)
		
	if global_position.x <= limit_l || global_position.x >= limit_r || global_position.y >= limit_d || global_position.y <= limit_u:
		velocity = -velocity
		
	
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
	if hitTimer > 0:
		hitTimer -= 0.2
		hitmask -= 0.01
		$Sprite.modulate = Color(hitmask, 0, 0)
	else:
		hitmask = 1
		$Sprite.modulate = Color(1, 1, 1)
	for body in $Hitbox.get_overlapping_bodies():
		if hitstun == 0 and body.get("DAMAGE") != null and body.get("TYPE") == "PLAYER":
			health -= body.get("DAMAGE")
			hitstun = 10
			knockdir = Vector2(global_position.x - body.global_position.x, global_position.y - body.global_position.y)
	
	for body in $Hitbox.get_overlapping_bodies():
		if hitstun == 0 and body.get("DAMAGE") != null and body.get("TYPE") == "BULLET":
			if body.glue:
				GLUE_VAR = 0.5
				$GlueTimer.start()
			hitTimer = 1
			health -= body.get("DAMAGE")
			hitstun = 5
			body.queue_free()





func _on_GlueTimer_timeout():
	$GlueTimer.stop()
	GLUE_VAR = 1
