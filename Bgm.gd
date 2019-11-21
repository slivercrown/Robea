extends Control

var count =0



# Called when the node enters the scene tree for the first time.
func _ready():
	
	$MenuBgm.play()
	AudioServer.set_bus_volume_db(AudioServer.get_bus_index("Master"), -40)

func _music_stop():
	$MenuBgm.stop()