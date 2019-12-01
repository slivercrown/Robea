extends Control

func _ready():
	Bgm.count +=1
	if(Bgm.count==1):
		_bgm_start()
		
func _bgm_start():
	Bgm._ready()


func _on_Button_pressed():
	Global.goto_scene("res://SceneFolder/OptionScene.tscn")


func _on_Button2_pressed():
	Global.goto_scene("res://World.tscn")
	Bgm.count =0


func _on_Button3_pressed():
	Global.goto_scene("res://SceneFolder/ShopScene.tscn")