extends Control

var count =0



# Called when the node enters the scene tree for the first time.
func _ready():
	
	$MenuBgm.play()
	AudioServer.set_bus_volume_db(AudioServer.get_bus_index("Master"), -40)

func _music_stop():
	$MenuBgm.stop()
	
func _gamemusic_start():
	$GameBgm.play()
	
func _gamemusic_quit():
	$GameBgm.stop()
	
func _effectsound_start():
	$Effect_Sound.play()
	
func _effectsound_quit():
	$Effect_Sound.stop()
