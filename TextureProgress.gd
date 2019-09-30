extends TextureProgress
	
onready var parent = get_parent() # Player 가져오기

func _ready():
	max_value = parent.default_health
	value = parent.health
	pass # Replace with function body.
	
func updateHealth(): 
	value = parent.health
	