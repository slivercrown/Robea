extends Node

func _ready():
	var new_player = preload('res://Player.tscn').instance()
	new_player.name = str(get_tree().get_network_unique_id())
	new_player.set_network_master(get_tree().get_network_unique_id())
	add_child(new_player)
	var info = Network.self_data
	new_player.init(info.name, info.position) 
	
