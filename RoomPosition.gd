extends Position2D

onready var testroom = preload("res://TestRoom.tscn")

var map_array = [ [0, 0, 0, 0],
				[0, 0, 0, 0],
				[0, 0, 0, 0],
				[0, 0, 0, 0]]


func _ready():
	init()
	for y in range(4):
		var row = map_array[y]
		for x in range(4):
			if row[x]:
				var room = testroom.instance()
				var room_pos = Vector2(480 * x, 270 * y) + Vector2(-480, -270)
				room.set_position(room_pos)
				get_node("/root/World").call_deferred("add_child",room)
				


func init():
	randomize()
	var x = 1
	var y = 1
	for i in range(16):
		map_array[x][y] = 1
		var dir = (randi() % 4)*90
		x += lengthdir_x(1, dir)
		y += lengthdir_y(1, dir)
		x = clamp(x, 0, 3)
		y = clamp(y, 0, 3)
	print(map_array)
	print(map_array[0].count(1))
	print(map_array[1].count(1))
	print(map_array[2].count(1))
	print(map_array[3].count(1))
	
	
		
func lengthdir_x(length, direction):
	return length * cos(direction)

func lengthdir_y(length, direction):
	return length * sin(direction)