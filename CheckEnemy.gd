extends Area2D

var EnemyCount = 0

func _ready():
	for body in $CheckEnemy.get_overlapping_bodies():
		if body.get("TYPE") == "ENEMY":
			EnemyCount += 1
	#print(EnemyCount)


