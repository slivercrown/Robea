#extends Node
#var gpgs = null	
#
#func _ready():
#	print('before gpgs')
#	if Engine.has_singleton("GodotPlayGameServices"):
#		print('init gpgs')
#
#		gpgs = Engine.get_singleton("GodotPlayGameServices")
#		gpgs.init(get_instance_id(), true)
#		gpgs.keepScreenOn(true)
#		gpgs.clearCache()
