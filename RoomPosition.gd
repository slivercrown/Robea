extends Position2D

onready var testroom = preload("res://TestRoom.tscn")
onready var testroom2 = preload("res://TestRoom2.tscn")
onready var testroom3 = preload("res://TestRoom3.tscn")

onready var itemroom = preload("res://Rooms/ItemRoom/ItemRoom.tscn")
onready var wallTop = preload("res://Wall_Top.tscn")
onready var wallLeft = preload("res://Wall_Left.tscn")
onready var wallRight = preload("res://Wall_Right.tscn")
onready var wallBottom = preload("res://Wall_Bottom.tscn")

var map_array = [ [0, 0, 0, 0],
				[0, 0, 0, 0],
				[0, 0, 0, 0],
				[0, 0, 0, 0]]


func _ready():
	init()
	map_array[1][1] = 4
	for y in range(4):
		var row = map_array[y]
		for x in range(4):
				if row[x] == 1:
					var room = testroom.instance()
					var room_pos = Vector2(480 * x, 270 * y) + Vector2(-480, -270)
					room.set_position(room_pos)
					get_node("/root/World").call_deferred("add_child",room)
					create_walls(x, y, room)
				elif row[x] == 2:
					var room = testroom2.instance()
					var room_pos = Vector2(480 * x, 270 * y) + Vector2(-480, -270)
					room.set_position(room_pos)
					get_node("/root/World").call_deferred("add_child",room)
					create_walls(x, y, room)
				elif row[x] == 3:
					var room = testroom3.instance()
					var room_pos = Vector2(480 * x, 270 * y) + Vector2(-480, -270)
					room.set_position(room_pos)
					get_node("/root/World").call_deferred("add_child",room)
					create_walls(x, y, room)
				elif row[x] == 4:
					var room = itemroom.instance()
					var room_pos = Vector2(480 * x, 270 * y) + Vector2(-480, -270)
					room.set_position(room_pos)
					get_node("/root/World").call_deferred("add_child",room)
					create_walls(x, y, room)


func init():
	randomize()
	var x = 1
	var y = 1
	for i in range(16):
		map_array[x][y] = randi() % 3 + 1
		var dir = (randi() % 4)*90
		x += lengthdir_x(1, dir)
		y += lengthdir_y(1, dir)
		x = clamp(x, 0, 3)
		y = clamp(y, 0, 3)
	"""print(map_array[0].count(1))
	print(map_array[1].count(1))
	print(map_array[2].count(1))
	print(map_array[3].count(1))"""
	
	
func lengthdir_x(length, direction):
	return length * cos(direction)

func lengthdir_y(length, direction):
	return length * sin(direction)
	
func create_walls(x, y, room):
	if y-1 == -1 || map_array[y-1][x] == 0:
		var twall = wallTop.instance()
		var wall_pos = Vector2(480 * x, 270 * y) + Vector2(-480, -270)
		twall.set_position(wall_pos)
		get_node("/root/World").call_deferred("add_child",twall)
	if x-1 == -1 || map_array[y][x-1] == 0:
		var lwall = wallLeft.instance()
		var wall_pos = Vector2(480 * x, 270 * y) + Vector2(-480, -270)
		lwall.set_position(wall_pos)
		get_node("/root/World").call_deferred("add_child",lwall)
	if x+1 == 4 || map_array[y][x+1] == 0:
		var rwall = wallRight.instance()
		var wall_pos = Vector2(480 * x, 270 * y) + Vector2(-480, -270)
		rwall.set_position(wall_pos)
		get_node("/root/World").call_deferred("add_child",rwall)
	if y+1 == 4 || map_array[y+1][x] == 0:
		var bwall = wallBottom.instance()
		var wall_pos = Vector2(480 * x, 270 * y) + Vector2(-480, -270)
		bwall.set_position(wall_pos)
		get_node("/root/World").call_deferred("add_child",bwall)