extends Control

func _ready():
	pass

func _on_Button_pressed():
    Global.goto_scene("res://SceneFolder/OptionScene.tscn")


func _on_Button2_pressed():
	Global.goto_scene("res://World.tscn")


func _on_Button3_pressed():
	Global.goto_scene("res://SceneFolder/ShopScene.tscn")
