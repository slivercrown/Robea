extends Control

# Declare member variables here. Examples:
# var a = 2
# var b = "text"

# Called when the node enters the scene tree for the first time.
func _ready():
	pass 


func _on_Button_pressed():
	Global.goto_scene("res://SceneFolder/GameScene.tscn")

func _on_Button2_pressed():
	Global.goto_scene("res://SceneFolder/MainScene.tscn")


