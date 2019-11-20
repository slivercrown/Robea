extends Control

func _ready():
	pass
	
func _on_Button_pressed():
    Global.goto_scene("res://SceneFolder/MainScene.tscn")


func _on_Button2_pressed():
	Global.goto_scene("res://SceneFolder/MainScene.tscn")
	
func _on_Plus_pressed():
	$TextureProgress.volume_up()

func _on_Minus_pressed():
	$TextureProgress.volume_down()
	
func _pressed():
	var node = get_tree().get_node().Music
	if(name=="Plus"):
		node.set_value(node.get_value()+node.step)
	elif(name=="Minus"):
		node.set_value(node.get_value()-node.step)
		
	var dbValue = node.value()
	