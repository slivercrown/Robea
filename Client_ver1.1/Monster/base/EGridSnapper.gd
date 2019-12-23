extends Position2D

var grid_position = Vector2(0,0) 
var grid_size = Vector2(480, 270) 
var limit_l = 0
var limit_r = 0
var limit_u = 0
var limit_d = 0 

onready var parent = get_parent()

func _ready():
	set_as_toplevel(true)
	update_grid_position()
	parent.limit_l = grid_position.x * grid_size.x + 18
	parent.limit_r = (grid_position.x + 1) * grid_size.x - 18
	parent.limit_u = grid_position.y * grid_size.y + 24
	parent.limit_d = (grid_position.y + 1) * grid_size.y - 24


func update_grid_position():
	var new_grid_position = calculate_grid_position()
	if grid_position == new_grid_position:
		return
	grid_position = new_grid_position
	parent.grid_position = new_grid_position


func calculate_grid_position(): # 어느 구역에 있는지 계산 
	var x = floor(parent.global_position.x / grid_size.x) 
	var y = floor(parent.global_position.y / grid_size.y) 
	return Vector2(x, y)

	
