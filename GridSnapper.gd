extends Position2D

var grid_position = Vector2(0,0) 
var grid_size = Vector2(480, 270) 

onready var parent = get_parent() # Player 가져오기

func _ready():
	$Camera2D.position = Vector2() 
	set_as_toplevel(true)
	update_grid_position()
	


func _physics_process(delta):
	update_grid_position()
	#print(grid_position)


func update_grid_position():
	var new_grid_position = calculate_grid_position()
	if grid_position == new_grid_position:
		return
	grid_position = new_grid_position
	parent.grid_position = new_grid_position
	jump_to_grid_position()


func calculate_grid_position(): # 플레이어가 어느 구역에 있는지 계산 
	var x = floor(parent.global_position.x / grid_size.x) 
	var y = floor(parent.global_position.y / grid_size.y) 
	return Vector2(x, y)


func jump_to_grid_position(): # 카메라 포지션 이동 
	position = grid_position * grid_size + (grid_size/2)
	
