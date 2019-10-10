extends Control

var player_name = "abc"
onready var Network = preload("res://Network.gd")

func _on_Button_pressed():
	Network.create_server(player_name)
	load_game()
	
func _on_Button2_pressed():
	Network.connect_to_server(player_name)
	load_game()

func load_game():
	Global.goto_scene("res://World.tscn")
	#get_tree().change_scene("")
"""
func _on_Button_pressed():
    Global.goto_scene("res://SceneFolder/OptionScene.tscn")

func _on_Button2_pressed():
	Global.goto_scene("res://World.tscn")
"""
func _on_Button3_pressed():
	Global.goto_scene("res://SceneFolder/ShopScene.tscn")
