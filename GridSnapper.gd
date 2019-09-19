extends Position2D

var grid_position = Vector2() 
var grid_size = Vector2() 

onready var parent = get_parent() # Player 가져오기

func _ready():
	$Camera2D.position = Vector2() 
	grid_size = Vector2(640,360)
	set_as_toplevel(true)
	update_grid_position()


func _physics_process(delta):
	update_grid_position()
	#print(position)
	#print(grid_size)


func update_grid_position():
	var new_grid_position = calculate_grid_position()
	if grid_position == new_grid_position:
		return
	grid_position = new_grid_position
	jump_to_grid_position()


func calculate_grid_position(): # 플레이어가 어느 구역에 있는지 계산 
	var x = round(parent.position.x / grid_size.x) 
	var y = round(parent.position.y / grid_size.y)
	return Vector2(x, y)


func jump_to_grid_position(): # 카메라 포지션 이동 
	position = grid_position * grid_size / 4 * 3
	
