extends Area2D

const FLOOR_SCENE = preload("res://Items/Active/Gum/act/Floor_Gum.tscn")
const TYPE = "GUMACT"

export var BULLET_SPEED = 180
var act = false
var velocity = Vector2()
var parent = null

func start_at(dir, pos):
	$Sprite.play("default")
	$Timer.start()
	set_process(true)
	set_global_position(pos)
	velocity = Vector2(BULLET_SPEED, 0).rotated(dir)
	
func _process(delta):
	set_global_position(get_global_position() + velocity * delta)
	if $Sprite.animation == "boom" && $Sprite.frame == $Sprite.frames.get_frame_count("boom")-1:
		var g = FLOOR_SCENE.instance()
		get_parent().add_child(g)
		g.start_at(Vector2(global_position.x,global_position.y))
		queue_free()
		
func _boom():
	act = true
	velocity = Vector2(0,0)
	$Sprite.play("boom")

func _on_Timer_timeout():
	if !act:
		velocity = Vector2(0,0)
		$Sprite.play("boom")


func _on_GumAct_body_entered(body):
	if body.get_name() == "TileMap":
		_boom()
