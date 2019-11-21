extends TextureProgress



func _ready():
	max_value = 24
	min_value = -80
	
	
func volume_up():
	
	value +=8
	AudioServer.set_bus_volume_db(AudioServer.get_bus_index("MenuBgm"), value)
	#print(AudioServer.get_bus_index("MenuBgm"))
	
	#vol = AudioServer.set_bus_volume_db(AudioServer.get_bus_index("MenuBgm"), value)
	
func volume_down():
	
	value -=8
	AudioServer.set_bus_volume_db(AudioServer.get_bus_index("MenuBgm"), value)
	#print(AudioServer.get_bus_index("MenuBgm"))

	#vol = AudioServer.set_bus_volume_db(AudioServer.get_bus_index("MenuBgm"), value)
	
	
	