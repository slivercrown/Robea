extends KinematicBody2D


func _ready():
	pass 

func init(nickname, start_position): # for network setting
	global_position = start_position