extends Node2D

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

#each scene load

var map_array = [ [0, 0, 0],
				[0, 0, 0],
				[0, 0, 0]]
#3 by 3 matrices
#0 is not instance, 1 is instance

func _ready():
	pass #total process

func random_process():
	for i in range(9):
		map_array[i] = randi() % 2 #0 or 1
	#0 to 9 map -> 0 or 1


func position_mapping(piece):
	if piece == 1:
		pass
	else: # piece == 0:
		pass #just pass~
	#get position -> mapping each value
	
	
func merging(piece):
	#size of map -> number of iteration or recursive
	#use func random_process()
	#get node(piece1 "..///piece.scene")
	#instancing -> set node
	if piece == 1:
		pass
		#get instance to position
	else: #piece == 0:
		pass #yeah just pass
	
	
#random arounding to path
#4 direction
#at least spawning 9 room
#limit to upper 3 room, downer 3 room  
"""
func test_random():
	for i in range(9):
		map_array[i] = randi() % 2 #0 or 1
		print(map_array[i])
#test end."""
	


