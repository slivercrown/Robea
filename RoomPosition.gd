extends Position2D

var map_size

var piece1
var piece2
var piece3

var piece4
var piece5
var piece6

var piece7
var piece8
var piece9
#change to array
"""
var p1 = $p1.get_position()
var p2 = $p2.get_position()
var p3 = $p3.get_position()

var p4 = $p4.get_position()
var p5 = $p5.get_position()
var p6 = $p6.get_position()

var p7 = $p7.get_position()
var p8 = $p8.get_position()
var p9 = $p9.get_position()
#change to array
"""
#each scene load

var map_array = [ [0, 0, 0, 0],
				[0, 0, 0, 0],
				[0, 0, 0, 0],
				[0, 0, 0, 0]]
#3 by 3 matrices
#0 is not instance, 1 is instance

func _ready():
	init()


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
		
func lengthdir_x(length, direction):
	return length * cos(direction)

func lengthdir_y(length, direction):
	return length * sin(direction)