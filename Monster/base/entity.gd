extends KinematicBody2D

var SPEED = 0

const TYPE = "ENEMY"
const DAMAGE = 10

var hitstun = 0
var health = 10

var movedir = Vector2(0,0)
var knockdir = Vector2(0,0)
var spritedir = "down"

var limit_l = 0
var limit_r = 0
var limit_u = 0
var limit_d = 0

func movement_loop():
	var motion
	if global_position.x <= limit_l || global_position.x >= limit_r || global_position.y >= limit_d || global_position.y <= limit_u:
			hitstun = 30
			knockdir = -movedir
			
	if hitstun == 0:
		motion = movedir.normalized() * SPEED
	else:
		motion = knockdir.normalized() * SPEED * 2
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
			health -= body.get("DAMAGE")
			print(health)
			hitstun = 10
			knockdir = Vector2(global_position.x - body.global_position.x, global_position.y - body.global_position.y)
		
