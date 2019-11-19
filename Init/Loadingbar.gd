extends TextureProgress
	
onready var parent = get_parent() # Player 가져오기

func _ready():
	max_value = parent.default_time
	value = parent.time
	pass # Replace with function body.
	
func updateTime(): 
	value = parent.time