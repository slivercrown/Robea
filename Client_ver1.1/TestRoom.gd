extends Node2D

const Monster = preload("res://Monster/base/EnemyType1/EnemyType1.tscn")

var EnemyCount = 0
var ItemBox = 1

func _on_EnemyType1_plus_count():
	EnemyCount += 1


func _on_EnemyType1_minus_count():
	EnemyCount -= 1
	if EnemyCount <= 0 && ItemBox >= 1:
		for a in ItemBox:
			ItemBox -= 1
			var b = Monster.instance()
			get_parent().add_child(b)
			var pos = Vector2(270,135)
			b.start_at(pos) # 생


func _on_EnemyType2_minus_count():
	EnemyCount -= 1
	if EnemyCount <= 0 && ItemBox >= 1:
		for a in ItemBox:
			ItemBox -= 1
			var b = Monster.instance()
			get_parent().add_child(b)
			var pos = Vector2(270,135)
			b.start_at(pos) # 생성


func _on_EnemyType2_plus_count():
	EnemyCount += 1

func _on_EnemyType3_minus_count():
	EnemyCount -= 1
	if EnemyCount <= 0 && ItemBox >= 1:
		for a in ItemBox:
			ItemBox -= 1
			var b = Monster.instance()
			get_parent().add_child(b)
			var pos = Vector2(270,135)
			b.start_at(pos) # 생성


func _on_EnemyType3_plus_count():
	EnemyCount += 1