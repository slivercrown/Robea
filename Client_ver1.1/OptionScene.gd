extends Control

func _ready():
	pass
	
func _on_Button_pressed():
	Global.goto_scene("res://SceneFolder/MainScene.tscn")
	Bgm._gamemusic_quit()
	


func _on_Button2_pressed():
	Global.goto_scene("res://SceneFolder/MainScene.tscn")
	Bgm._gamemusic_quit()
	
func _on_Plus_pressed():
	$MenuVolume.volume_up()

func _on_Minus_pressed():
	$MenuVolume.volume_down()
	
func _on_Plus2_pressed():
	$GameVolume.volume_up()

func _on_Minus2_pressed():
	$GameVolume.volume_down()
	
func _on_Plus3_pressed():
	$EffectVolume.volume_up()

func _on_Minus3_pressed():
	$EffectVolume.volume_down()
	
	
func _pressed():
	var node = get_tree().get_node().Music
	if(name=="Plus"):
		node.set_value(node.get_value()+node.step)
	elif(name=="Minus"):
		node.set_value(node.get_value()-node.step)
		
	var dbValue = node.value()
	